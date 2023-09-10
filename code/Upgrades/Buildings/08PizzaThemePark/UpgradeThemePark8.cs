using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark8 : Upgrade
{
    public override string Ident => "upgrade_theme_park_8";
    public override string Name => "Gold Adventure World";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => double.Parse("165,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/adventure_world_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_theme_park") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

