using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark9 : Upgrade
{
    public override string Ident => "upgrade_theme_park_9";
    public override string Name => "Prismatic Adventure World";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => double.Parse("165,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/adventure_world_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_theme_park") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

