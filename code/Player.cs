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
    public double TotalPizzasBaked { get; set; } = 0;
    public double TotalClicks { get; set; } = 0;
    public Dictionary<string, ulong> Buildings { get; set; } = new();
    public Dictionary<string, bool> Achievements { get; set; } = new();
    public Dictionary<string, bool> Upgrades { get; set; } = new();

    private Dictionary<string, double> buildingTimers = new();
    public Dictionary<string, double> Multipliers = new();
    public double MittenMultiplier = 1;

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

    public double Click()
    {
        double value = PizzasPerClick;
        if(HasUpgrade("upgrade_pizza_clicker_6"))
        {
            double ovenMittsValue = GetTotalBuildingCount() * MittenMultiplier;
            value += ovenMittsValue;
        }
        GivePizzas(value);
        TotalClicks++;
        return value;
    }

    public void Save()
    {
        if(Member.Id != Game.SteamId) return;

        foreach(var achievement in GameMenu.AllAchievements)
        {
            if(!Achievements.ContainsKey(achievement.Ident) && achievement.CheckUnlockCondition(this))
            {
                Achievement.Unlock(this, achievement.Ident);
            }
        }

        FileSystem.Data.WriteJson(Game.SteamId.ToString(), this);
    }

    public double GetBuildingCount(string ident)
    {
        if(!Buildings.ContainsKey(ident)) return 0;
        return Buildings[ident];
    }

    public double GetTotalBuildingCount()
    {
        double count = 0;
        foreach(var building in Buildings)
        {
            count += building.Value;
        }
        return count;
    }

    public double GetBuildingMultiplier(string ident)
    {
        if(!Multipliers.ContainsKey(ident)) return 1;
        return Multipliers[ident];
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

    public bool HasAchievement(string ident)
    {
        if(!Achievements.ContainsKey(ident)) return false;
        return Achievements[ident];
    }

    public bool GiveAchievement(string ident)
    {
        if(Achievements.ContainsKey(ident) && Achievements[ident]) return false;
        Achievements[ident] = true;
        Save();
        return true;
    }

    public bool HasUpgrade(string ident)
    {
        if(!Upgrades.ContainsKey(ident)) return false;
        return Upgrades[ident];
    }

    public bool GiveUpgrade(string ident)
    {
        if(Upgrades.ContainsKey(ident) && Upgrades[ident]) return false;

        foreach(var upgrade in GameMenu.AllUpgrades)
        {
            if(upgrade.Ident == ident && Pizzas >= upgrade.Cost)
            {
                Pizzas -= upgrade.Cost;
                Upgrades[ident] = true;
                upgrade.OnPurchase(this);
                Save();
                return true;
            }
        }

        return false;
    }

    public List<Upgrade> AvailableUpgrades()
    {
        List<Upgrade> upgrades = new();
        foreach(var upgrade in GameMenu.AllUpgrades)
        {
            if(!HasUpgrade(upgrade.Ident) && upgrade.CheckUnlockCondition(this))
            {
                upgrades.Add(upgrade);
            }
        }
        return upgrades;
    }

    public List<Upgrade> PurchasedUpgrades()
    {
        List<Upgrade> upgrades = new();
        foreach(var upgrade in GameMenu.AllUpgrades)
        {
            if(HasUpgrade(upgrade.Ident))
            {
                upgrades.Add(upgrade);
            }
        }
        return upgrades;
    }

    public double GetTotalUpgradeCount()
    {
        double count = 0;
        foreach(var upgrade in Upgrades)
        {
            if(upgrade.Value) count++;
        }
        return count;
    }

    public void GivePizzas(double pizzas)
    {
        Pizzas += pizzas;
        TotalPizzasBaked += pizzas;
    }

    public void AddMultiplier(string ident, double multiplier)
    {
        if(!Multipliers.ContainsKey(ident)) Multipliers.Add(ident, 1);
        Multipliers[ident] *= multiplier;
    }

    public void Update()
    {
        PizzasPerSecond = 0;
        foreach(var building in GameMenu.AllBuildings)
        {
            double buildingCount = GetBuildingCount(building.Ident);
            if(buildingCount == 0) continue;
            PizzasPerSecond += building.PizzasPerSecond * buildingCount * GetBuildingMultiplier(building.Ident);

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

        data.PizzasPerClick = 1;
        data.MittenMultiplier = 1;
        foreach(var upgrade in GameMenu.AllUpgrades)
        {
            if(data.HasUpgrade(upgrade.Ident))
            {
                upgrade.OnPurchase(data);
            }
        }

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