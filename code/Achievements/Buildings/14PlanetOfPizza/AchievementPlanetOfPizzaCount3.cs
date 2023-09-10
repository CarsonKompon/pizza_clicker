using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPlanetOfPizzaCount3 : Achievement
{
    public override string Ident => "building_14_planet_of_pizza_count_03";
    public override string Name => "Cosmic crust";
    public override string Description => "Purchase 100 Planet of Pizzas";
    public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("planet_of_pizza") >= 100;
	}

}

