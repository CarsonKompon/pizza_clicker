using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPlanetOfPizzaCount4 : Achievement
{
	public override string Ident => "building_14_planet_of_pizza_count_04";
	public override string Name => "Meteorite mozzarella";
	public override string Description => "Purchase 150 Planet of Pizzas";
	public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "planet_of_pizza" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "planet_of_pizza" ) / 150d;
	}
}
