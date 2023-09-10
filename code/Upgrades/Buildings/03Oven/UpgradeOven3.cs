using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeOven3 : Upgrade
{
    public override string Ident => "upgrade_oven_3";
    public override string Name => "Gold Oven";
    public override string Description => "Ovens are twice as effective";
    public override double Cost => 550_000;
    public override string Icon => "ui/upgrades/oven_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("oven") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("oven", 2);
    }

}

