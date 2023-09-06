using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional8 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_8";
    public override string Name => "Gold Multiverse Pizza Hub";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => double.Parse("85,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/multiverse_hub_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("interdimensional_pizzeria") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

