using System.Collections.Generic;
using System.IO;
using Sandbox;
using Sandbox.UI;

namespace PizzaClicker;

public class Player
{
    public Friend Member;

    // Variables
    public ulong Pizzas { get; set; } = 0;
    public ulong PizzasPerSecond { get; set; } = 0;
    public ulong PizzasPerClick { get; set; } = 1;
    public Dictionary<string, ulong> Buildings { get; set; } = new();

    public Player(){}

    public Player(Friend member)
    {
        Member = member;
    }

    public Player(long steamid)
    {
        Member = new Friend(steamid);
    }

    public void Click()
    {
        Pizzas += PizzasPerClick;
    }

    public void Save()
    {
        if(Member.Id != Game.SteamId) return;

        FileSystem.Data.WriteJson(Game.SteamId.ToString(), this);
    }

    public ulong GetBuildingCount(string ident)
    {
        if(!Buildings.ContainsKey(ident)) return 0;
        return Buildings[ident];
    }

    public bool BuyBuilding(Building building)
    {
        ulong cost = building.GetCost(GetBuildingCount(building.Ident));
        if(Pizzas < cost) return false;

        Pizzas -= cost;
        if(!Buildings.ContainsKey(building.Ident)) Buildings.Add(building.Ident, 0);
        Buildings[building.Ident] += 1;

        CalculatePizzasPerSecond();

        return true;
    }

    public bool HasPizzas(ulong pizzas)
    {
        return Pizzas >= pizzas;
    }

    void CalculatePizzasPerSecond()
    {
        PizzasPerSecond = 0;
        foreach(var building in GameMenu.AllBuildings)
        {
            PizzasPerSecond += (ulong)(building.PizzasPerSecond * GetBuildingCount(building.Ident));
        }
    }

    public static Player LoadPlayer()
    {
        var data = FileSystem.Data.ReadJson<Player>(Game.SteamId.ToString());
        if (data == null) return new Player(Game.SteamId);
        data.Member = new Friend(Game.SteamId);
        data.CalculatePizzasPerSecond();

        return data;
    }

    public ByteStream GetDataStream()
    {
        ByteStream data = ByteStream.Create(26);
        data.Write((byte)NETWORK_MESSAGE.PLAYER_UPDATE);
        data.Write(Pizzas);
        data.Write(PizzasPerSecond);
        data.Write(PizzasPerClick);
        return data;
    }

    public void ReadDataStream(ByteStream data)
    {
        Pizzas = data.Read<ulong>();
        PizzasPerSecond = data.Read<ulong>();
        PizzasPerClick = data.Read<ulong>();
    }

}