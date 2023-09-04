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

    public double SecondsPerPizza(Player player)
    {
        return 1f / GetPizzasPerSecond(player);
    }

    public double GetPizzasPerSecond(Player player)
    {
        return PizzasPerSecond * player.GetBuildingCount(Ident);
    }
}

