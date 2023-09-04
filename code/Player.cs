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
    public double Pizzas { get; set; } = 0;
    public double PizzasPerSecond { get; set; } = 0;
    public double PizzasPerClick { get; set; } = 1;
    public Dictionary<string, ulong> Buildings { get; set; } = new();

    private Dictionary<string, double> buildingTimers = new();

    double particleTimer = 0f;

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
        double cost = building.GetCost(this);
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
    }

    public void Update()
    {
        PizzasPerSecond = 0;
        foreach(var building in GameMenu.AllBuildings)
        {
            ulong buildingCount = GetBuildingCount(building.Ident);
            if(buildingCount == 0) continue;
            PizzasPerSecond += building.PizzasPerSecond * buildingCount;

            if(!buildingTimers.ContainsKey(building.Ident)) buildingTimers[building.Ident] = 0;
            buildingTimers[building.Ident] += Time.Delta;
            double seconds = building.SecondsPerPizza(this);
            while(buildingTimers[building.Ident] >= seconds)
            {
                GivePizzas(1);
                buildingTimers[building.Ident] -= seconds;
            }
        }

        particleTimer += Time.Delta;
        if(particleTimer > 0.1f)
        {
            var val = Math.Floor(PizzasPerSecond / 10d);
            if(val > 0)
            {
                string particleText = "+" + NumberHelper.ToStringAbbreviated(val);
                var rand = new Random();
                var particle = new TextParticle(Screen.Size * new Vector2(rand.Float(), rand.Float(0.5f, 1f)) * GameMenu.Instance.ScaleFromScreen, particleText);
                particle.AddClass("gained");
                GameMenu.Instance.AddChild(particle);
                particleTimer = 0f;
            }
        }
    }

    public string GetPizzasPerSecond()
    {
        if(PizzasPerSecond.ToString().Length < 4)
        {
            return PizzasPerSecond.ToString("N1");
        }
        return NumberHelper.ToStringAbbreviated(PizzasPerSecond);
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
        ByteStream data = ByteStream.Create(17);
        data.Write((byte)NETWORK_MESSAGE.PLAYER_UPDATE);
        data.Write((double)Pizzas);
        data.Write((double)PizzasPerSecond);
        return data;
    }

    public void ReadDataStream(ByteStream data)
    {
        Pizzas = data.Read<double>();
        PizzasPerSecond = data.Read<double>();
    }

}