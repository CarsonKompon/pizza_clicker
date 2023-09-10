using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPlanetOfPizzaCount7 : Achievement
{
    public override string Ident => "building_14_planet_of_pizza_count_07";
    public override string Name => "Red planet, red sauce";
    public override string Description => "Purchase 300 Planet of Pizzas";
    public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("planet_of_pizza") >= 300;
	}

}

