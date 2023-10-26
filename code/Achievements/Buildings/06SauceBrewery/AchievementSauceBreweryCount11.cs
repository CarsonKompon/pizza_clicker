using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSauceBreweryCount11 : Achievement
{
	public override string Ident => "building_06_sauce_brewery_count_11";
	public override string Name => "Half-Thousand Brews";
	public override string Description => "Purchase 500 Sauce Brewerys";
	public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 500;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) / 500d;
	}
}
