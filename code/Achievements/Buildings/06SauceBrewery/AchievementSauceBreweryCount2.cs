using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSauceBreweryCount2 : Achievement
{
	public override string Ident => "building_06_sauce_brewery_count_02";
	public override string Name => "Sauced up";
	public override string Description => "Purchase 50 Sauce Brewerys";
	public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) / 50d;
	}
}
