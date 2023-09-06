using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark1 : Upgrade
{
    public override string Ident => "upgrade_theme_park_1";
    public override string Name => "Bronze Theme Park";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => 3_300_000_000;
    public override string Icon => "ui/upgrades/theme_park_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_theme_park") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

