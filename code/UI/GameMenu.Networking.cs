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

        ushort messageId = data.Read<ushort>();

        switch((NETWORK_MESSAGE)messageId)
        {
            case NETWORK_MESSAGE.PLAYER_UPDATE:

                break;

        }
    }

    void NetworkPlayerUpdate(Player player)
    {
        Lobby.BroadcastMessage(player.GetDataStream());
    }

}