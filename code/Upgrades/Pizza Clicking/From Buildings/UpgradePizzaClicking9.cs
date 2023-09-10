using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker9 : Upgrade
{
    
    public override string Ident => "upgrade_pizza_clicker_9";
    public override string Name => "Gold Oven Mitts";
    public override string Description => "Multiplies the gain from Oven Mitts by 20";
    public override double Cost => 1_000_000_000;
    public override string Icon => "ui/upgrades/oven_mitts_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetTotalBuildingCount() >= 400;
    }

    public override void OnPurchase(Player player)
    {
        player.MittenMultiplier *= 20;
    }

}

