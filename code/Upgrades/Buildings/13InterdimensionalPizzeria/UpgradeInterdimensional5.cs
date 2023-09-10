using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional5 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_5";
    public override string Name => "Multiverse Pizza Hub";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => double.Parse("850,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/multiverse_hub.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("interdimensional_pizzeria") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

