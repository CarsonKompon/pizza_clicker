using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeRollingPin8 : Upgrade
{
    public override string Ident => "upgrade_rolling_pin_8";
    public override string Name => "Gold Pizza Sheeter";
    public override string Description => "Rolling Pins are twice as effective";
    public override double Cost => 10_000_000_000;
    public override string Icon => "ui/upgrades/pizza_sheeter_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("rolling_pin") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("rolling_pin", 2);
    }

}

