using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Upgrade
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual string Description => "";
    public virtual double Cost => 0;
    public virtual string Icon => "ui/pizzas/cheese_pizza.png";

    public virtual bool CheckUnlockCondition(Player player)
    {
        return false;
    }

    public virtual void OnPurchase(Player player)
    {

    }

    public double GetCost(Player player)
    {
        double cost = Cost;
        if(player.HasBlessing("upgrade_discount_01"))
        {
            cost *= 0.99d;
            if(player.HasBlessing("upgrade_discount_02"))
            {
                cost *= 1d - (Math.Floor(player.GetBuildingCount("rolling_pin") / 100d) * 0.01d);
            }
        }

        return Math.Floor(cost);
    }

}

