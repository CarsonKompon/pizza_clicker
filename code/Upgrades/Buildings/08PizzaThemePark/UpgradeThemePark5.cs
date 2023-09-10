using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark5 : Upgrade
{
    public override string Ident => "upgrade_theme_park_5";
    public override string Name => "Pizza Adventure World";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => 1_650_000_000_000_000;
    public override string Icon => "ui/upgrades/adventure_world.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_theme_park") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

