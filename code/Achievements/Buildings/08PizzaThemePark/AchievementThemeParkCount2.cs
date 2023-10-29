using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementThemeParkCount2 : Achievement
{
	public override string Ident => "building_08_theme_park_count_02";
	public override string Name => "Roller Coaster Tycheese";
	public override string Description => "Purchase 50 Pizza Theme Parks";
	public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) / 50d;
	}
}
