using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPlanetOfPizzaCount1 : Achievement
{
    public override string Ident => "building_14_planet_of_pizza_count_01";
    public override string Name => "Extraterrestrial estate";
    public override string Description => "Purchase 1 Planet of Pizza";
    public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("planet_of_pizza") >= 1;
	}

}

