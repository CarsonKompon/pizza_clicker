using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker15 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_14";
    public override string Name => "Prismatic Heat-Resistant Gloves";
    public override string Description => "Multiplies the gain from Oven Mitts by 20";
    public override double Cost => double.Parse("10,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/heat_gloves_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetTotalBuildingCount() >= 1750;
    }

    public override void OnPurchase(Player player)
    {
        player.MittenMultiplier *= 20;
    }

}

