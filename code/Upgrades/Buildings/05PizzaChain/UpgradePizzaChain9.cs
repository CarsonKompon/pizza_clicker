using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaChain9 : Upgrade
{
    public override string Ident => "upgrade_pizza_chain_9";
    public override string Name => "Prismatic Pizza Restaurant";
    public override string Description => "Pizza Chains are twice as effective";
    public override double Cost => double.Parse("65,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_restaurant_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_chain") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_chain", 2);
    }

}

