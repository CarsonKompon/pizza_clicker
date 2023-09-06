using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePlanetPizza4 : Upgrade
{
    public override string Ident => "upgrade_planet_pizza_4";
    public override string Name => "Prismatic Planet of Pizza";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => double.Parse("105,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/planet_pizza_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("planet_of_pizza") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("planet_of_pizza", 2);
    }

}

