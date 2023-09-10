using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeOven8 : Upgrade
{
    public override string Ident => "upgrade_oven_8";
    public override string Name => "Gold Brick Oven";
    public override string Description => "Ovens are twice as effective";
    public override double Cost => 550_000_000_000_000_000;
    public override string Icon => "ui/upgrades/brick_oven_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("oven") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("oven", 2);
    }

}

