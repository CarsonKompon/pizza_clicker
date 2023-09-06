using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeRollingPin1 : Upgrade
{
    public override string Ident => "upgrade_rolling_pin_1";
    public override string Name => "Bronze Rolling Pin";
    public override string Description => "Rolling Pins are twice as effective";
    public override double Cost => 100;
    public override string Icon => "ui/upgrades/rolling_pin_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("rolling_pin") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("rolling_pin", 2);
    }

}

