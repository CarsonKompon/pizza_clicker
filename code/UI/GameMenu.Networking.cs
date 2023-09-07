using System.Linq;
using Sandbox;
using Sandbox.Menu;

namespace PizzaClicker;

enum NETWORK_MESSAGE
{
    NONE,
    PLAYER_UPDATE,
    ACHIEVEMENT_UNLOCK
}

public partial class GameMenu
{
    void OnNetworkMessage(ILobby.NetworkMessage msg)
    {

        ByteStream data = msg.Data;

        byte messageId = data.Read<byte>();

        switch((NETWORK_MESSAGE)messageId)
        {

            // Player Update Network Message
            case NETWORK_MESSAGE.PLAYER_UPDATE:
                if(msg.Source.Id == Game.SteamId) return;

                Player player = null;
                foreach(var p in Players)
                {
                    if(p.Member.Id == msg.Source.Id)
                    {
                        player = p;
                        break;
                    }
                }
                if(player == null)
                {
                    player = new Player(msg.Source.Id);
                    Players.Add(player);
                }
                player.ReadDataStream(data);

                break;

            // Achievement Unlock Network Message
            case NETWORK_MESSAGE.ACHIEVEMENT_UNLOCK:

                int byteLength = data.Read<int>();
                byte[] wordBytes = new byte[byteLength];
                for(int i=0; i<byteLength; i++)
                {
                    wordBytes[i] = data.Read<byte>();
                }
                var ident = System.Text.Encoding.Unicode.GetString(wordBytes);

                foreach(var achievement in AllAchievements)
                {
                    if(achievement.Ident == ident)
                    {
                        Chat.CreateChatEntry("", msg.Source.Name + " unlocked the achievement \"" + achievement.Name + "\"", "achievement");
                        break;
                    }
                }

                break;

        }
    }

    void NetworkPlayerUpdate(Player player)
    {
        if(player == null) return;
        Lobby.BroadcastMessage(player.GetDataStream());
    }

    public void NetworkAchievementUnlock(Player player, string ident)
    {
        if(player == null) return;
        byte[] wordBytes = System.Text.Encoding.Unicode.GetBytes(ident);
        ByteStream data = ByteStream.Create(5 + wordBytes.Length);
        data.Write((byte)NETWORK_MESSAGE.ACHIEVEMENT_UNLOCK);
        data.Write((int)wordBytes.Length);
        for(int i=0; i<wordBytes.Length; i++)
        {
            data.Write(wordBytes[i]);
        }

        Lobby.BroadcastMessage(data);
    }

}