using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark6 : Upgrade
{
    public override string Ident => "upgrade_theme_park_6";
    public override string Name => "Bronze Adventure World";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => 165_000_000_000_000_000;
    public override string Icon => "ui/upgrades/adventure_world_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_theme_park") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

