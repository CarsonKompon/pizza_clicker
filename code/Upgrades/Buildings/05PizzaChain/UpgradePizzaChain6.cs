using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaChain6 : Upgrade
{
    public override string Ident => "upgrade_pizza_chain_6";
    public override string Name => "Bronze Pizza Restaurant";
    public override string Description => "Pizza Chains are twice as effective";
    public override double Cost => 65_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_restaurant_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_chain") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_chain", 2);
    }

}

