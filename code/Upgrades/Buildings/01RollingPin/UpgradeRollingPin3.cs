using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeRollingPin3 : Upgrade
{
    public override string Ident => "upgrade_rolling_pin_3";
    public override string Name => "Gold Rolling Pin";
    public override string Description => "Rolling Pins are twice as effective";
    public override double Cost => 10_000;
    public override string Icon => "ui/upgrades/rolling_pin_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("rolling_pin") >= 10;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("rolling_pin", 2);
    }

}

