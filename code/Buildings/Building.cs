using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Building
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual double Cost => 0;
    public virtual double PizzasPerSecond => 0;

    public double GetCost(Player player, ulong free = 0)
    {
        var amount = player.GetBuildingCount(Ident);
        return Math.Floor(Cost * Math.Pow(1.15, amount - free));
    }

    public double GetIndividualPizzasPerSecond(Player player)
    {
        return PizzasPerSecond * player.GetBuildingMultiplier(Ident) * player.GetTemporaryMultiplier(Ident);
    }

    public double GetPizzasPerSecond(Player player)
    {
        double val = PizzasPerSecond
                    * player.GetBuildingCount(Ident)
                    * player.GetBuildingMultiplier(Ident)
                    * player.GetTemporaryMultiplier(Ident)
                    * player.TotalMultiplier
                    * (1d + (player.LegacyDough / 100d));
        if(player.AchievementMultiplier > 0)
        {
            val *= 1d + (player.GetAchievementCount() * player.AchievementMultiplier);
        }
        if(player.HasBlessing("pizzas_per_friend_01"))
        {
            val *= 1d + (GameMenu.Instance.Lobby.MemberCount / 100d);
        }
        if(player.FrenzyTime > 0) val *= 7;
        return val;
    }
}

