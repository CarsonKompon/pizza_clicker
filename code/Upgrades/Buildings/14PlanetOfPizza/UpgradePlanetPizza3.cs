using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePlanetPizza3 : Upgrade
{
    public override string Ident => "upgrade_planet_pizza_3";
    public override string Name => "Gold Planet of Pizza";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => 1_050_000_000_000_000_000;
    public override string Icon => "ui/upgrades/planet_pizza_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("planet_of_pizza") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("planet_of_pizza", 2);
    }

}

