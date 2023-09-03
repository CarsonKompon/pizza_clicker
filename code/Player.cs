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
    public double PizzasPerSecondFloat { get; set; } = 0;
    public BigNumber PizzasPerClick { get; set; } = new(1);
    public Dictionary<string, ulong> Buildings { get; set; } = new();

    private Dictionary<string, double> buildingTimers = new();

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
        BigNumber cost = building.GetCost(GetBuildingCount(building.Ident));
        if(Pizzas < cost) return false;

        Pizzas -= cost;
        if(!Buildings.ContainsKey(building.Ident)) Buildings.Add(building.Ident, 0);
        Buildings[building.Ident] += 1;

        Save();

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


    RealTimeSince TestTimer = 0f;
    public void Update()
    {
        PizzasPerSecond = new BigNumber(0);
        PizzasPerSecondFloat = 0;
        foreach(var building in GameMenu.AllBuildings)
        {
            ulong buildingCount = GetBuildingCount(building.Ident);
            if(buildingCount == 0) continue;
            PizzasPerSecond += building.PizzasPerSecond * buildingCount;
            PizzasPerSecondFloat += building.PizzasPerSecondFloat * (double)buildingCount;

            if(!buildingTimers.ContainsKey(building.Ident)) buildingTimers[building.Ident] = 0;
            buildingTimers[building.Ident] += Time.Delta;
            double seconds = building.SecondsPerPizza(buildingCount);
            Log.Info(seconds);
            while(buildingTimers[building.Ident] >= seconds)
            {
                GivePizzas(1);
                buildingTimers[building.Ident] -= seconds;
            }
        }

        // Put integer value of PizzasPerSecondFloat in PizzasPerSecond
        PizzasPerSecond += (long)Math.Floor(PizzasPerSecondFloat);
        PizzasPerSecondFloat -= Math.Floor(PizzasPerSecondFloat);
    }

    public string GetPizzasPerSecond()
    {
        if(PizzasPerSecond.ToString().Length < 4)
        {
            return (double.Parse(PizzasPerSecond.ToString()) + PizzasPerSecondFloat).ToString("N1");
        }
        return PizzasPerSecond.ToStringAbbreviated();
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
        ByteStream data = ByteStream.Create(9 + Pizzas.GetByteSize() + PizzasPerClick.GetByteSize() + PizzasPerSecond.GetByteSize());
        data.Write((byte)NETWORK_MESSAGE.PLAYER_UPDATE);
        Pizzas.WriteToStream(ref data);
        PizzasPerClick.WriteToStream(ref data);
        PizzasPerSecond.WriteToStream(ref data);
        data.Write((double)PizzasPerSecondFloat);
        return data;
    }

    public void ReadDataStream(ByteStream data)
    {
        Pizzas = BigNumber.ReadFromStream(ref data);
        PizzasPerClick = BigNumber.ReadFromStream(ref data);
        PizzasPerSecond = BigNumber.ReadFromStream(ref data);
        PizzasPerSecondFloat = data.Read<double>();
    }

}