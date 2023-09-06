using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePlanetPizza2 : Upgrade
{
    public override string Ident => "upgrade_planet_pizza_2";
    public override string Name => "Silver Planet of Pizza";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => 105_000_000_000_000_000;
    public override string Icon => "ui/upgrades/planet_pizza_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("planet_of_pizza") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("planet_of_pizza", 2);
    }

}

