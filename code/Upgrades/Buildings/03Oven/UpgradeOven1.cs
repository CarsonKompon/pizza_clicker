using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeOven1 : Upgrade
{
    public override string Ident => "upgrade_oven_1";
    public override string Name => "Bronze Oven";
    public override string Description => "Ovens are twice as effective";
    public override double Cost => 11_000;
    public override string Icon => "ui/upgrades/oven_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("oven") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("oven", 2);
    }

}

