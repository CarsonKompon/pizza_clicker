using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaChain2 : Upgrade
{
    public override string Ident => "upgrade_pizza_chain_2";
    public override string Name => "Silver Pizza Chain";
    public override string Description => "Pizza Chains are twice as effective";
    public override double Cost => 6_500_000;
    public override string Icon => "ui/upgrades/pizza_chain_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_chain") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_chain", 2);
    }

}

