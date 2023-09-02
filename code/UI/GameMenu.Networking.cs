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

                foreach(var player in Players)
                {
                    if(player.Member.Id == msg.Source.Id)
                    {
                        player.ReadDataStream(data);
                    }
                }

                break;

        }
    }

    void NetworkPlayerUpdate(Player player)
    {
        Lobby.BroadcastMessage(player.GetDataStream());
    }

}