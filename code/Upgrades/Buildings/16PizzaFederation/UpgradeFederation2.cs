using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeFederation2 : Upgrade
{
    public override string Ident => "upgrade_pizza_federation_2";
    public override string Name => "Silver Pizza Federation";
    public override string Description => "Pizza Federations are twice as effective";
    public override double Cost => 15_500_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_federation_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_federation") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_federation", 2);
    }

}

