using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping18Tomatoes : Upgrade
{
    public override string Ident => "upgrade_topping_018_tomatoes";
    public override string Name => "Tomato Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 500_000_000_000;
    public override string Icon => "ui/upgrades/topping_tomatoes.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 25_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

