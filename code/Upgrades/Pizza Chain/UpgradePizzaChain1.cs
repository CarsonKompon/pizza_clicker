using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaChain1 : Upgrade
{
    public override string Ident => "upgrade_pizza_chain_1";
    public override string Name => "Bronze Pizza Chain";
    public override string Description => "Pizza Chains are twice as effective";
    public override double Cost => 1_300_000;
    public override string Icon => "ui/upgrades/pizza_chain_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_chain") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_chain", 2);
    }

}

