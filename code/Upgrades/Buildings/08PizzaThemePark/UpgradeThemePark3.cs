using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark3 : Upgrade
{
    public override string Ident => "upgrade_theme_park_3";
    public override string Name => "Gold Theme Park";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => 165_000_000_000;
    public override string Icon => "ui/upgrades/theme_park_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_theme_park") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

