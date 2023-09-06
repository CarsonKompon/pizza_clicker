using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeFederation1 : Upgrade
{
    public override string Ident => "upgrade_pizza_federation_1";
    public override string Name => "Bronze Pizza Federation";
    public override string Description => "Pizza Federations are twice as effective";
    public override double Cost => 3_100_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_federation_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_federation") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_federation", 2);
    }

}

