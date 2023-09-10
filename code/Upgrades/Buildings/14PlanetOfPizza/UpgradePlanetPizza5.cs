using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePlanetPizza5 : Upgrade
{
    public override string Ident => "upgrade_planet_pizza_5";
    public override string Name => "Galactic Pizza Empire";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => double.Parse("10,500,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/galactic_empire.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("planet_of_pizza") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("planet_of_pizza", 2);
    }

}

