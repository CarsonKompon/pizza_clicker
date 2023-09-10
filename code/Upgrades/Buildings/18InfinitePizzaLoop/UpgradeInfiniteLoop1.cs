using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInfiniteLoop1 : Upgrade
{
    public override string Ident => "upgrade_pizza_loop_1";
    public override string Name => "Bronze Infinite Pizza Loop";
    public override string Description => "Infinite Pizza Loops are twice as effective";
    public override double Cost => double.Parse("120,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_loop_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("infinite_pizza_loop") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("infinite_pizza_loop", 2);
    }

}

