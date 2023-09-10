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
    public double HandMadePizzas { get; set; } = 0;
    public double TotalClicks { get; set; } = 0;
    public double TotalGoldClicks { get; set; } = 0;
    public double LegacyDough { get; set; } = 0;
    public double LastLevel { get; set; } = 0;
    public double TotalLegacyBaked { get; set; } = 0;
    public double TotalPizzasBakedAllTime { get; set; } = 0;
    public double HeavenlyCrust { get; set; } = 0;
    public double AscensionCount { get; set; } = 0;
    public Dictionary<string, ulong> Buildings { get; set; } = new();
    public Dictionary<string, bool> Achievements { get; set; } = new();
    public Dictionary<string, bool> Upgrades { get; set; } = new();
    public Dictionary<string, bool> Blessings { get; set; } = new();

    private Dictionary<string, double> buildingTimers = new();
    public Dictionary<string, double> Multipliers = new();
    public Dictionary<string, double> TemporaryMultipliers = new();
    public Dictionary<string, double> TemporaryTimers = new();
    public double MittenMultiplier = 1;
    public double TotalMultiplier = 1;
    public double AchievementMultiplier = 0;
    public double ResearchSpeed = 1;
    public double PpSPercent = 0;
    public float GoldMinTime = 300;
    public float GoldMaxTime = 900;
    public float GoldDuration = 8f;
    public double GoldMultiplier = 1d;
    public double HeavenlyPercent = 0d;

    double particleTimer = 0f;

    public RealTimeUntil GoldTimer;
    public RealTimeUntil FrenzyTime;
    public RealTimeUntil ClickFrenzy;

    public Player()
    {
        GoldTimer = new Random().Float(GoldMinTime, GoldMaxTime);
    }

    public Player(Friend member) : this()
    {
        Member = member;
    }

    public Player(long steamid) : this()
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
        if(PpSPercent > 0)
        {
            value += Math.Floor((double)PizzasPerSecond * (PpSPercent / 100));
        }
        if(HasBlessing("starting_gloves_1"))
        {
            value *= 1.1d;
            if(HasBlessing("starting_gloves_2"))
            {
                double percent = 1d + (GetBuildingCount("oven") / 200d);
                double max = HasBlessing("starting_gloves_3") ? 2d : 1.5d;
                if(percent > max) percent = max;
                value *= percent;
            }
        }

        if(ClickFrenzy > 0)
        {
            value *= 777d;
        }

        Sound.FromScreen("mouse.click");

        HandMadePizzas += value;
        GivePizzas(value);
        TotalClicks++;
        return value;
    }

    public void GoldenClick(Vector2 pos)
    {
        Random rand = new Random();
        string particleText = "Golden Pizza!";
        float chance = rand.Float();

        // Lucky Pizza
        if(chance < 0.35f)
        {
            double bankedPercent = Math.Floor(Pizzas * 0.15) + 13;
            double ppsPercent = Math.Floor(PizzasPerSecond * 900) + 13;
            double realVal = Math.Min(bankedPercent, ppsPercent);
            particleText = $"Lucky Pizza!\n+{NumberHelper.ToStringAbbreviated(realVal)} Pizzas";
            Pizzas += realVal;
        }

        // Pizza Frenzy
        else if(chance < 0.65f)
        {
            var value = Math.Round(77 * GoldMultiplier);
            FrenzyTime = (float)value;
            particleText = $"Pizza Frenzy!\nx7 PpS for {value}s";
            Notifications.Popup("Pizza Frenzy!", $"x7 pizzas/sec for {value}s", "gold frenzy", "/ui/pizzas/gold_pizza.png", FrenzyTime);
        }

        // Click Frenzy
        else if(chance < 0.07f)
        {
            ClickFrenzy = 13 * (float)GoldMultiplier;
            particleText = $"Click Frenzy!\nx7 pizzas/click for {ClickFrenzy}s";
            Notifications.Popup("Click Frenzy!", $"x777 pizzas/click for {ClickFrenzy}s", "gold click", "/ui/pizzas/gold_pizza.png", ClickFrenzy);
        }

        // Building Bonus
        else
        {
            var buildings = GetOwnedBuildings();
            var building = buildings[rand.Int(buildings.Count)];
            double multiplier = (10 * GetBuildingCount(building.Ident) + 100d)/100d;
            TemporaryMultipliers[building.Ident] = multiplier;
            TemporaryTimers[building.Ident] = 30 * GoldMultiplier;
            particleText = $"Building Bonus!\n{NumberHelper.ToStringAbbreviated(multiplier)}x {building.Name} PpS for {TemporaryTimers[building.Ident]}s";
            Notifications.Popup("Building Bonus!", $"{NumberHelper.ToStringAbbreviated(multiplier)}x {building.Name} pizzas/sec for {TemporaryTimers[building.Ident]}s", "gold building", "/ui/buildings/" + building.Ident + ".png", (float)TemporaryTimers[building.Ident]);
        }

        TotalGoldClicks++;

        var particle = new TextParticle(pos, particleText, "gold", true, 2);
        GameMenu.Instance.AddChild(particle);
    }

    public void StartAscension()
    {
        Save();
        HeavenlyCrust += LegacyDough;
        GameMenu.Instance.Ascending = true;
    }

    public void Ascend()
    {
        Pizzas = 0;
        PizzasPerClick = 1;
        PizzasPerSecond = 0;
        TotalPizzasBakedAllTime += TotalPizzasBaked;
        TotalPizzasBaked = 0;
        HandMadePizzas = 0;
        TotalClicks = 0;
        TotalGoldClicks = 0;
        LegacyDough += HeavenlyCrust;
        TotalLegacyBaked += HeavenlyCrust;
        LastLevel = LegacyDough;
        HeavenlyCrust = 0;
        Buildings.Clear();
        Upgrades.Clear();
        Multipliers.Clear();
        TemporaryMultipliers.Clear();
        TemporaryTimers.Clear();
        MittenMultiplier = 1;
        TotalMultiplier = 1;
        AchievementMultiplier = 0;
        ResearchSpeed = 1;
        PpSPercent = 0;
        GoldMinTime = 300;
        GoldMaxTime = 900;
        GoldDuration = 8f;
        GoldMultiplier = 1d;
        GoldTimer = new Random().Float(GoldMinTime, GoldMaxTime);
        FrenzyTime = 0;
        ClickFrenzy = 0;
        AscensionCount++;

        foreach(var blessing in GameMenu.AllBlessings)
        {
            if(HasBlessing(blessing.Ident))
            {
                blessing.OnAfterAscension(this);
            }
        }

        Save();
        GameMenu.Instance.Ascending = false;
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

    public double GetTemporaryMultiplier(string ident)
    {
        if(!TemporaryMultipliers.ContainsKey(ident)) return 1;
        return TemporaryMultipliers[ident];
    }

    public bool BuyBuilding(Building building)
    {
        double cost = building.GetCost(this);
        if(Pizzas < cost) return false;

        Pizzas -= cost;
        GiveBuilding(building.Ident);

        return true;
    }

    public bool GiveBuilding(string ident, ulong amount = 1)
    {
        if(!Buildings.ContainsKey(ident)) Buildings.Add(ident, 0);
        Buildings[ident] += amount;
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

    public int GetAchievementCount()
    {
        return Achievements.Count;
    }

    public double GetAchievementResearch()
    {
        return Achievements.Count * ResearchSpeed;
    }
    
    public double GetBuildingResearch(string ident)
    {
        return GetBuildingCount(ident) * ResearchSpeed;
    }

    public double GetTotalBuildingResearch()
    {
        return GetTotalBuildingCount() * ResearchSpeed;
    }

    public bool HasBlessing(string ident)
    {
        if(!Blessings.ContainsKey(ident)) return false;
        return Blessings[ident];
    }

    public bool GiveBlessing(string ident)
    {
        if(Blessings.ContainsKey(ident) && Blessings[ident]) return false;
        Blessings[ident] = true;
        Save();
        return true;
    }

    public bool BuyBlessing(Blessing blessing)
    {
        foreach(var req in blessing.Requires)
        {
            if(!string.IsNullOrEmpty(req) && !HasBlessing(req)) return false;
        }
        if(HeavenlyCrust < blessing.Cost) return false;

        HeavenlyCrust -= blessing.Cost;
        GiveBlessing(blessing.Ident);
        blessing.OnActivate(this);
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
            var cost = upgrade.GetCost(this);
            if(upgrade.Ident == ident && Pizzas >= cost)
            {
                Pizzas -= cost;
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
        // Spawn the gold pizza
        if(GoldTimer)
        {
            Log.Info("GOLD TIME");
            GameMenu.Instance.SpawnGoldPizza();
            GoldTimer = new Random().Float(GoldMinTime, GoldMaxTime);
        }

        // Calculate PpS
        PizzasPerSecond = 0;
        double totalDeltaPizzas = 0;  // Total pizzas to be given during this frame

        foreach (var building in GameMenu.AllBuildings)
        {
            double buildingCount = GetBuildingCount(building.Ident);
            if (buildingCount == 0) continue;

            double buildingPps = building.GetPizzasPerSecond(this);
            PizzasPerSecond += buildingPps;

            if (!buildingTimers.ContainsKey(building.Ident)) buildingTimers[building.Ident] = 0;
            
            // Use delta time to update the timers
            buildingTimers[building.Ident] += Time.Delta;
            
            // Calculate how many pizzas this building should produce during this frame
            double deltaPizzas = buildingPps * Time.Delta;
            
            // Add to total
            totalDeltaPizzas += deltaPizzas;
            
            // Optional: You can handle fractional pizzas by accumulating the remainder for the next frame
            // double fractionalPizzas = deltaPizzas % 1;
            // buildingTimers[building.Ident] = fractionalPizzas;
        }

        // Accumulate fractional pizzas from the previous frame
        if (!buildingTimers.ContainsKey("total"))
        {
            buildingTimers["total"] = 0;
        }
        buildingTimers["total"] += totalDeltaPizzas;

        // Give whole pizzas, keep fractional part
        double wholePizzas = Math.Floor(buildingTimers["total"]);
        if (wholePizzas >= 1)
        {
            GivePizzas(wholePizzas);
            buildingTimers["total"] -= wholePizzas;  // keep the fractional part
        }

        // Advance temporary timers
        foreach (var timer in TemporaryTimers)
        {
            TemporaryTimers[timer.Key] -= Time.Delta;
            if (TemporaryTimers[timer.Key] <= 0)
            {
                TemporaryTimers.Remove(timer.Key);
                TemporaryMultipliers.Remove(timer.Key);
            }
        }


        // Spawn particles
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

    public List<Building> GetOwnedBuildings()
    {
        List<Building> buildings = new();
        foreach(var building in GameMenu.AllBuildings)
        {
            if(GetBuildingCount(building.Ident) > 0)
            {
                buildings.Add(building);
            }
        }
        return buildings;
    }

    public static Player LoadPlayer()
    {

        var data = FileSystem.Data.ReadJson<Player>(Game.SteamId.ToString());
        if (data == null) return new Player(Game.SteamId);
        data.Member = new Friend(Game.SteamId);

        data.PizzasPerClick = 1;
        data.MittenMultiplier = 1;
        data.TotalMultiplier = 1;
        data.PpSPercent = 0;
        data.GoldDuration = 8;
        data.GoldMultiplier = 1d;
        data.ResearchSpeed = 1;
        foreach(var upgrade in GameMenu.AllUpgrades)
        {
            if(data.HasUpgrade(upgrade.Ident))
            {
                upgrade.OnPurchase(data);
            }
        }
        foreach(var blessing in GameMenu.AllBlessings)
        {
            if(data.HasBlessing(blessing.Ident))
            {
                blessing.OnActivate(data);
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