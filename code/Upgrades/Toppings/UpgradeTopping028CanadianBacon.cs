using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping28CanadianBacon : Upgrade
{
    public override string Ident => "upgrade_topping_028_canadian_bacon";
    public override string Name => "Canadian Bacon Topping";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 10_000_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_canadian_bacon.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 500_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

