using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSauceBreweryCount8 : Achievement
{
	public override string Ident => "building_06_sauce_brewery_count_08";
	public override string Name => "Liquid Gold";
	public override string Description => "Purchase 350 Sauce Brewerys";
	public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) / 350d;
	}
}
