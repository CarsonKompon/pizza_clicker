using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPlanetOfPizzaCount2 : Achievement
{
    public override string Ident => "building_14_planet_of_pizza_count_02";
    public override string Name => "Planetary pioneer";
    public override string Description => "Purchase 50 Planet of Pizzas";
    public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("planet_of_pizza") >= 50;
	}

}

