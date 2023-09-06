using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark4 : Upgrade
{
    public override string Ident => "upgrade_theme_park_4";
    public override string Name => "Prismatic Theme Park";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => 16_500_000_000_000;
    public override string Icon => "ui/upgrades/theme_park_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_theme_park") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

