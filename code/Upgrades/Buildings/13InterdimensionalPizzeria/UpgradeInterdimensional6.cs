using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional6 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_6";
    public override string Name => "Bronze Multiverse Pizza Hub";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => double.Parse("85,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/multiverse_hub_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("interdimensional_pizzeria") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

