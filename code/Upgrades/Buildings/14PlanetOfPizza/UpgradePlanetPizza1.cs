using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePlanetPizza1 : Upgrade
{
    public override string Ident => "upgrade_planet_pizza_1";
    public override string Name => "Bronze Planet of Pizza";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => 21_000_000_000_000_000;
    public override string Icon => "ui/upgrades/planet_pizza_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("planet_of_pizza") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("planet_of_pizza", 2);
    }

}

