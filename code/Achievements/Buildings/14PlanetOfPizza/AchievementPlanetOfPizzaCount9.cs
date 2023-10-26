using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPlanetOfPizzaCount9 : Achievement
{
	public override string Ident => "building_14_planet_of_pizza_count_09";
	public override string Name => "Milky whey";
	public override string Description => "Purchase 400 Planet of Pizzas";
	public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "planet_of_pizza" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "planet_of_pizza" ) / 400d;
	}
}
