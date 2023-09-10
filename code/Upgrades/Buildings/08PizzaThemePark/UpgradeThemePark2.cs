using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeThemePark2 : Upgrade
{
    public override string Ident => "upgrade_theme_park_2";
    public override string Name => "Silver Theme Park";
    public override string Description => "Pizza Theme Parks are twice as effective";
    public override double Cost => 16_500_000_000;
    public override string Icon => "ui/upgrades/theme_park_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_theme_park") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_theme_park", 2);
    }

}

