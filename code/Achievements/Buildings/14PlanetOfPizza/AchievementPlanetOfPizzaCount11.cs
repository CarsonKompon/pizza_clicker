using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPlanetOfPizzaCount11 : Achievement
{
    public override string Ident => "building_14_planet_of_pizza_count_11";
    public override string Name => "The final frontier";
    public override string Description => "Purchase 500 Planet of Pizzas";
    public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("planet_of_pizza") >= 500;
	}

}

