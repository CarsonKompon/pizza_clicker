using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox;
using Sandbox.Menu;

namespace PizzaClicker;

internal enum NETWORK_MESSAGE : byte
{
	NONE,
	PLAYER_UPDATE,
	ACHIEVEMENT_UNLOCK
}

public partial class GameMenu
{
	private readonly Dictionary<long, RealTimeSince> LastPlayersAchievementNetworkMessage = new();
	private readonly Dictionary<long, RealTimeSince> LastPlayersAchievementUnlock = new();

	private void OnNetworkMessage( ILobby.NetworkMessage msg )
	{
		var data = msg.Data;
		var messageId = data.Read<NETWORK_MESSAGE>();

		switch ( messageId )
		{
			// Player Update Network Message
			case NETWORK_MESSAGE.PLAYER_UPDATE:
				if ( msg.Source.Id == Game.SteamId )
				{
					return;
				}

				var playerId = msg.Source.Id;
				var player = Players.FirstOrDefault( p => p.Member.Id == playerId, null );
				if ( player == null )
				{
					player = new( msg.Source.Id );
					Players.Add( player );
				}

				player.ReadDataStream( data );

				break;

			// Achievement Unlock Network Message
			case NETWORK_MESSAGE.ACHIEVEMENT_UNLOCK:
				if ( LastPlayersAchievementNetworkMessage.TryGetValue( msg.Source.Id, out var value ) && value < 1f )
				{
					return;
				}

				var byteLength = data.Read<int>();
				var wordBytes = new byte[byteLength];

				for ( var i = 0; i < byteLength; i++ )
				{
					wordBytes[i] = data.Read<byte>();
				}

				var ident = Encoding.Unicode.GetString( wordBytes );
				var achievement = AllAchievements.FirstOrDefault( a => a.Ident == ident, null );
				if ( achievement == null )
				{
					break;
				}

				Chat.CreateChatEntry( "", $"{msg.Source.Name} unlocked the achievement \"{achievement.Name}\"", "achievement" );

				LastPlayersAchievementNetworkMessage[msg.Source.Id] = 0;

				break;

			case NETWORK_MESSAGE.NONE:
			default:
				break;
		}
	}

	private void NetworkPlayerUpdate( Player player )
	{
		if ( player == null )
		{
			return;
		}

		Lobby.BroadcastMessage( player.GetDataStream() );
	}

	public void NetworkAchievementUnlock( Player player, string ident )
	{
		if ( player == null )
		{
			return;
		}

		if ( LastPlayersAchievementUnlock.TryGetValue( player.Member.Id, out var value ) && value < 1f )
		{
			return;
		}

		var wordBytes = Encoding.Unicode.GetBytes( ident );
		var data = ByteStream.Create( 5 + wordBytes.Length );

		data.Write( NETWORK_MESSAGE.ACHIEVEMENT_UNLOCK );
		data.Write( wordBytes.Length );

		for ( var i = 0; i < wordBytes.Length; i++ )
		{
			data.Write( wordBytes[i] );
		}

		Lobby.BroadcastMessage( data );

		LastPlayersAchievementUnlock[player.Member.Id] = 0;
	}
}
