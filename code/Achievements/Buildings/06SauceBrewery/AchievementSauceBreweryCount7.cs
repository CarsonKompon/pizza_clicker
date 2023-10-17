using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSauceBreweryCount7 : Achievement
{
	public override string Ident => "building_06_sauce_brewery_count_07";
	public override string Name => "The saucy way";
	public override string Description => "Purchase 300 Sauce Brewerys";
	public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 300;
	}
}
