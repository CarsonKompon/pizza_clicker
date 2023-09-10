using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePlanetPizza8 : Upgrade
{
    public override string Ident => "upgrade_planet_pizza_8";
    public override string Name => "Gold Pizza Empire";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => double.Parse("1,050,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/galactic_empire_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("planet_of_pizza") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("planet_of_pizza", 2);
    }

}

