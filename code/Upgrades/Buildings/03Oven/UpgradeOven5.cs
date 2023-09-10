using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeOven5 : Upgrade
{
    public override string Ident => "upgrade_oven_5";
    public override string Name => "Brick Oven";
    public override string Description => "Ovens are twice as effective";
    public override double Cost => 5_500_000_000;
    public override string Icon => "ui/upgrades/brick_oven.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("oven") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("oven", 2);
    }

}

