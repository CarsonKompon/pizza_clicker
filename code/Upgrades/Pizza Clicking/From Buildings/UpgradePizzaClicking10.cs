using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker10 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_10";
    public override string Name => "Prismatic Oven Mitts";
    public override string Description => "Multiplies the gain from Oven Mitts by 20";
    public override double Cost => 10_000_000_000;
    public override string Icon => "ui/upgrades/oven_mitts_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetTotalBuildingResearch() >= 600;
    }

    public override void OnPurchase(Player player)
    {
        player.MittenMultiplier *= 20;
    }

}

