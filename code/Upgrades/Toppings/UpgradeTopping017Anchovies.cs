using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping17Anchovies : Upgrade
{
    public override string Ident => "upgrade_topping_017_anchovies";
    public override string Name => "Anchovies Topping";
    public override string Description => "Pizza production is increased by 5%";
    public override double Cost => 100_000_000_000;
    public override string Icon => "ui/upgrades/topping_anchovies.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 5_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.05d;
    }

}

