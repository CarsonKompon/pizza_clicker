using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping1Pepperoni : Upgrade
{
    public override string Ident => "upgrade_topping_001_pepperoni";
    public override string Name => "Pepperoni Topping";
    public override string Description => "Pizza production is increased by 1%";
    public override double Cost => 1_000_000;
    public override string Icon => "ui/upgrades/topping_pepperoni.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 50_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.01d;
    }

}

