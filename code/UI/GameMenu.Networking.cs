using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox;
using Sandbox.Network;
using PizzaClicker.Achievements;
using PizzaClicker.Blessings;
using PizzaClicker.Buildings;
using PizzaClicker.Upgrades;

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

	// UI References
	public static GameMenu Instance { get; set; }
	public static Chatbox Chat { get; set; }

	// Lobby Variables
	public LobbyInformation Lobby { get; set; }
	public List<Player> Players { get; set; } = new List<Player>();

	// Game Variables
	public Player LocalPlayer => Players.FirstOrDefault( p => p.Member.Id == Game.SteamId );
	public static List<Building> AllBuildings { get; set; } = new List<Building>();
	public static List<Achievement> AllAchievements { get; set; } = new List<Achievement>();
	public static List<Upgrade> AllUpgrades { get; set; } = new List<Upgrade>();
	public static List<Blessing> AllBlessings { get; set; } = new List<Blessing>();
	public bool Ascending = false;

	// Timers
	private RealTimeSince _lastSave = 0f;
	private RealTimeSince _lastNetworkSync = 0f;

	protected override void OnAwake()
	{
		Instance = this;

		AllBuildings = TypeLibrary.GetTypes<Building>()
			.Select( t => TypeLibrary.Create<Building>( t.TargetType ) )
			.Where( b => b.Cost > 0 )
			.OrderBy( b => b.Cost )
			.ToList();

		AllAchievements = TypeLibrary.GetTypes<Achievement>()
			.Select( t => TypeLibrary.Create<Achievement>( t.TargetType ) )
			.Where( a => a.Ident != "none" )
			.ToList();

		AllUpgrades = TypeLibrary.GetTypes<Upgrade>()
			.Select( t => TypeLibrary.Create<Upgrade>( t.TargetType ) )
			.Where( u => u.Cost > 0 )
			.OrderBy( u => u.Cost )
			.ToList();

		AllBlessings = TypeLibrary.GetTypes<Blessing>()
			.Select( t => TypeLibrary.Create<Blessing>( t.TargetType ) )
			.Where( b => b.Cost > 0 )
			.ToList();

		InitPlayer( Game.SteamId );
	}

	protected override async void OnStart()
	{
		if ( !GameNetworkSystem.IsActive )
		{
			var lobbies = (await GameNetworkSystem.QueryLobbies())
				.Where( l => l.Members < l.MaxMembers && l.Name == "Pizza Clicker" )
				.OrderByDescending( l => l.Members );

			BaseSoundComponent

			if ( lobbies.Count() > 0 )
			{
				Lobby = lobbies.First();
				GameNetworkSystem.Connect( Lobby.LobbyId );
			}
			else
			{
				GameNetworkSystem.CreateLobby();
			}
		}
	}

	protected override void OnUpdate()
	{
		if ( !Ascending )
		{
			LocalPlayer?.Update();

			if ( _lastSave > 1f )
			{
				LocalPlayer?.Save();
				_lastSave = 0f;
			}
		}

		if ( _lastNetworkSync > 2f )
		{
			NetworkPlayerUpdate( LocalPlayer.Pizzas, LocalPlayer.PizzasPerSecond );
			_lastNetworkSync = 0f;
		}

	}

	private void InitPlayer( long steamid )
	{
		Player player;

		if ( steamid == Game.SteamId )
		{
			player = Player.LoadPlayer();
			Players.Add( player );

			NetworkPlayerUpdate( player.Pizzas, player.PizzasPerSecond );
		}
		else
		{
			player = new Player( steamid );
			Players.Add( player );
		}

		Chat?.CreateChatEntry( "", $"{player.Member.Name} opened their pizzeria!", "join-message" );
	}

	private void ClickPizza()
	{
		var val = LocalPlayer.Click();
		var particleText = "+" + NumberHelper.ToStringAbbreviated( val );
		TextParticle particle = new( Mouse.Position * Panel.ScaleFromScreen, particleText, (LocalPlayer.ClickFrenzy > 0 ? "gold" : ""), true );

		Panel.AddChild( particle );
	}

	public void SpawnGoldPizza()
	{
		Random rand = new();
		Vector2 pos = new( rand.Next( 10, 80 ), rand.Next( 10, 80 ) );
		GoldPizza goldenPizza = new( LocalPlayer, pos, LocalPlayer.GoldDuration );

		Panel.AddChild( goldenPizza );
	}

	[Broadcast]
	public void SendChat( string message )
	{
		Chat.CreateChatEntry( $"{Rpc.Caller.DisplayName}:", message, "", (long)Rpc.Caller.SteamId );
	}


	[Broadcast]
	private void NetworkPlayerUpdate( double pizzas, double pizzasPerSecond )
	{
		var playerId = Rpc.Caller.Id;
		var player = Players.FirstOrDefault( p => p.Member.Id == (long)Rpc.Caller.SteamId, null );
		if ( player == null )
		{
			player = new( (long)Rpc.Caller.SteamId );
			Players.Add( player );
		}

		player.Pizzas = pizzas;
		player.PizzasPerSecond = pizzasPerSecond;
	}

	[Broadcast]
	public void NetworkAchievementUnlock( string ident )
	{
		if ( LastPlayersAchievementUnlock.TryGetValue( (long)Rpc.Caller.SteamId, out var value ) && value < 1f )
		{
			return;
		}

		var achievement = AllAchievements.FirstOrDefault( a => a.Ident == ident, null );
		if ( achievement == null )
		{
			return;
		}

		Chat.CreateChatEntry( "", $"{Rpc.Caller.DisplayName} unlocked the achievement \"{achievement.Name}\"", "achievement" );

		LastPlayersAchievementNetworkMessage[(long)Rpc.Caller.SteamId] = 0;

		LastPlayersAchievementUnlock[(long)Rpc.Caller.SteamId] = 0;
	}

	void OnConnected( Connection conn )
	{
		InitPlayer( (long)conn.SteamId );
	}

	void OnDisconnected( Connection conn )
	{
		Players.RemoveAll( p => p.Member.Id == (long)conn.SteamId );

		Chat.CreateChatEntry( "", $"{conn.Name} has closed their pizzeria!", "leave-message" );
	}

	void OnActive( Connection conn )
	{
	}

	protected override int BuildHash()
	{
		return HashCode.Combine( Ascending, GameNetworkSystem.IsActive );
	}
}
