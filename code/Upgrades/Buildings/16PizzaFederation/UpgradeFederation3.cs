using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeFederation3 : Upgrade
{
    public override string Ident => "upgrade_pizza_federation_3";
    public override string Name => "Gold Pizza Federation";
    public override string Description => "Pizza Federations are twice as effective";
    public override double Cost => double.Parse("155,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_federation_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_federation") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_federation", 2);
    }

}

