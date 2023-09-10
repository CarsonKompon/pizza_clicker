using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional1 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_1";
    public override string Name => "Bronze Interdimensional Pizzeria";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => 1_700_000_000_000_000;
    public override string Icon => "ui/upgrades/interdimensional_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("interdimensional_pizzeria") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

