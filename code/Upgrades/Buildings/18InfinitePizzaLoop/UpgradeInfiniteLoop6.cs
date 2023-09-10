using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInfiniteLoop6 : Upgrade
{
    public override string Ident => "upgrade_pizza_loop_6";
    public override string Name => "Bronze Eternal Pizza Cycle";
    public override string Description => "Infinite Pizza Loops are twice as effective";
    public override double Cost => double.Parse("6,000,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_cycle_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("infinite_pizza_loop") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("infinite_pizza_loop", 2);
    }

}

