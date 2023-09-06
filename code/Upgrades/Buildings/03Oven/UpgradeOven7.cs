using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeOven7 : Upgrade
{
    public override string Ident => "upgrade_oven_7";
    public override string Name => "Silver Brick Oven";
    public override string Description => "Ovens are twice as effective";
    public override double Cost => 550_000_000_000_000;
    public override string Icon => "ui/upgrades/brick_oven_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("oven") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("oven", 2);
    }

}

