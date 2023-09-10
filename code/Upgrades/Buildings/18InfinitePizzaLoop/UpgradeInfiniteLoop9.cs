using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInfiniteLoop9 : Upgrade
{
    public override string Ident => "upgrade_pizza_loop_9";
    public override string Name => "Prismatic Eternal Pizza Cycle";
    public override string Description => "Infinite Pizza Loops are twice as effective";
    public override double Cost => double.Parse("6,000,000,000,000,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_cycle_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("infinite_pizza_loop") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("infinite_pizza_loop", 2);
    }

}

