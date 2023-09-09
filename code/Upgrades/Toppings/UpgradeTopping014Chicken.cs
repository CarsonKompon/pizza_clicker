using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping14Chicken: Upgrade
{
    public override string Ident => "upgrade_topping_014_chicken";
    public override string Name => "Chicken Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 10_000_000_000;
    public override string Icon => "ui/upgrades/topping_chicken.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 500_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

