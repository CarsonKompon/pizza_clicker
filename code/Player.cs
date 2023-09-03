using System;
using System.Collections.Generic;
using System.IO;
using Sandbox;
using Sandbox.UI;

namespace PizzaClicker;

public class Player
{
    public Friend Member;

    // Variables
    public BigNumber Pizzas { get; set; } = new(0);
    public BigNumber PizzasPerSecond { get; set; } = new(0);
    public BigNumber PizzasPerClick { get; set; } = new(1);
    public Dictionary<string, ulong> Buildings { get; set; } = new();

    private Dictionary<string, BigNumber> buildingTimers = new();

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

        Log.Info(Pizzas.ToStringAbbreviated());
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
        BigNumber cost = building.GetCost(GetBuildingCount(building.Ident));
        if(Pizzas < cost) return false;

        Pizzas -= cost;
        if(!Buildings.ContainsKey(building.Ident)) Buildings.Add(building.Ident, 0);
        Buildings[building.Ident] += 1;

        return true;
    }

    public void GivePizzas(ulong pizzas)
    {
        Pizzas += pizzas;

        string particleText = "+" + pizzas.ToString("N0");
        var rand = new Random();
        var particle = new TextParticle(Screen.Size * new Vector2(rand.Float(), rand.Float(0.5f, 1f)) * GameMenu.Instance.ScaleFromScreen, particleText);
        particle.AddClass("gained");
        GameMenu.Instance.AddChild(particle);
    }

    public void Update()
    {
        
        PizzasPerSecond = 0;
        // foreach(var building in GameMenu.AllBuildings)
        // {
        //     ulong buildingCount = GetBuildingCount(building.Ident);
        //     PizzasPerSecond += building.PizzasPerSecond * (double)buildingCount;

        //     if(!buildingTimers.ContainsKey(building.Ident)) buildingTimers[building.Ident] = 0;
        //     buildingTimers[building.Ident] += Time.Delta;
        //     BigFloat seconds = building.SecondsPerPizza();
        //     while(buildingTimers[building.Ident] >= seconds)
        //     {
        //         GivePizzas(buildingCount);
        //         buildingTimers[building.Ident] -= seconds;
        //     }
        // }

        Log.Info(Pizzas);

    }

    public static Player LoadPlayer()
    {

        var data = FileSystem.Data.ReadJson<Player>(Game.SteamId.ToString());
        if (data == null) return new Player(Game.SteamId);
        data.Member = new Friend(Game.SteamId);

        return data;
    }

    public ByteStream GetDataStream()
    {
        ByteStream data = ByteStream.Create(1 + Pizzas.GetByteSize() + PizzasPerClick.GetByteSize() + PizzasPerSecond.GetByteSize());
        data.Write((byte)NETWORK_MESSAGE.PLAYER_UPDATE);
        Pizzas.WriteToStream(ref data);
        PizzasPerClick.WriteToStream(ref data);
        PizzasPerSecond.WriteToStream(ref data);
        return data;
    }

    public void ReadDataStream(ByteStream data)
    {
        Pizzas = BigNumber.ReadFromStream(ref data);
        PizzasPerClick = BigNumber.ReadFromStream(ref data);
        PizzasPerSecond = BigNumber.ReadFromStream(ref data);
    }

}