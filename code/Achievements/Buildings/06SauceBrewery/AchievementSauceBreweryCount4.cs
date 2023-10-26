using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSauceBreweryCount4 : Achievement
{
	public override string Ident => "building_06_sauce_brewery_count_04";
	public override string Name => "Big brew";
	public override string Description => "Purchase 150 Sauce Brewerys";
	public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) / 150d;
	}
}
