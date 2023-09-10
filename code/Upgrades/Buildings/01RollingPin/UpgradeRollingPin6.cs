using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeRollingPin6 : Upgrade
{
    public override string Ident => "upgrade_rolling_pin_6";
    public override string Name => "Bronze Pizza Sheeter";
    public override string Description => "Rolling Pins are twice as effective";
    public override double Cost => 100_000_000;
    public override string Icon => "ui/upgrades/pizza_sheeter_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("rolling_pin") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("rolling_pin", 2);
    }

}

