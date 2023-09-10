using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional9 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_9";
    public override string Name => "Prismatic Multiverse Pizza Hub";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => double.Parse("85,000,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/multiverse_hub_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("interdimensional_pizzeria") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

