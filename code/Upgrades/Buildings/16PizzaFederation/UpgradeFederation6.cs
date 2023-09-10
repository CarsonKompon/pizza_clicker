using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeFederation6 : Upgrade
{
    public override string Ident => "upgrade_pizza_federation_6";
    public override string Name => "Bronze United Federation";
    public override string Description => "Pizza Federations are twice as effective";
    public override double Cost => double.Parse("155,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/united_federation_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_federation") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_federation", 2);
    }

}

