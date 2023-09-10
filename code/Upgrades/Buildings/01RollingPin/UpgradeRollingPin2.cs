using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeRollingPin2 : Upgrade
{
    public override string Ident => "upgrade_rolling_pin_2";
    public override string Name => "Silver Rolling Pin";
    public override string Description => "Rolling Pins are twice as effective";
    public override double Cost => 500;
    public override string Icon => "ui/upgrades/rolling_pin_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("rolling_pin") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("rolling_pin", 2);
    }

}

