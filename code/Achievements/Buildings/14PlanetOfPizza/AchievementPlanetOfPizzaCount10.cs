using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPlanetOfPizzaCount10 : Achievement
{
	public override string Ident => "building_14_planet_of_pizza_count_10";
	public override string Name => "Universal pizza overlord";
	public override string Description => "Purchase 450 Planet of Pizzas";
	public override string Icon => "/ui/buildings/planet_of_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "planet_of_pizza" ) >= 450;
	}
}
