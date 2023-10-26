using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSauceBreweryCount6 : Achievement
{
	public override string Ident => "building_06_sauce_brewery_count_06";
	public override string Name => "Barrel Roll";
	public override string Description => "Purchase 250 Sauce Brewerys";
	public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) / 250d;
	}
}
