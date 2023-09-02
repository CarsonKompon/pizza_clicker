using System.Linq;
using Sandbox;
using Sandbox.Menu;

namespace PizzaClicker;

enum NETWORK_MESSAGE
{
    NONE,
    PLAYER_UPDATE,
}

public partial class GameMenu
{
    void OnNetworkMessage(ILobby.NetworkMessage msg)
    {
        if(msg.Source.Id == Game.SteamId) return;

        ByteStream data = msg.Data;

        byte messageId = data.Read<byte>();

        switch((NETWORK_MESSAGE)messageId)
        {
            case NETWORK_MESSAGE.PLAYER_UPDATE:

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

        }
    }

    void NetworkPlayerUpdate(Player player)
    {
        Lobby.BroadcastMessage(player.GetDataStream());
    }

}