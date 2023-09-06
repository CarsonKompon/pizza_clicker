using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeInterdimensional4 : Upgrade
{
    public override string Ident => "upgrade_interdimensional_4";
    public override string Name => "Prismatic Interdimensional Pizzeria";
    public override string Description => "Interdimensional Pizzerias are twice as effective";
    public override double Cost => 8_500_000_000_000_000_000;
    public override string Icon => "ui/upgrades/interdimensional_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("interdimensional_pizzeria") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("interdimensional_pizzeria", 2);
    }

}

