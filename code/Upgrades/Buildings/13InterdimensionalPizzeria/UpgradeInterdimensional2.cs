using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional2 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_2";
    public override string Name => "Silver Interdimensional Pizzeria";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => 8_500_000_000_000_000;
    public override string Icon => "ui/upgrades/interdimensional_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("interdimensional_pizzeria") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

