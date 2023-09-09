using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping2Cheese : Upgrade
{
    public override string Ident => "upgrade_topping_002_cheese";
    public override string Name => "Extra Cheese Topping";
    public override string Description => "Pizza production is increased by 1%";
    public override double Cost => 5_000_000;
    public override string Icon => "ui/upgrades/topping_extra_cheese.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 250_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.01d;
    }

}

