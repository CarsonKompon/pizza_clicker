using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaChain5 : Upgrade
{
    public override string Ident => "upgrade_pizza_chain_5";
    public override string Name => "Pizza Restaurant";
    public override string Description => "Pizza Chains are twice as effective";
    public override double Cost => 650_000_000_000;
    public override string Icon => "ui/upgrades/pizza_restaurant.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_chain") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_chain", 2);
    }

}

