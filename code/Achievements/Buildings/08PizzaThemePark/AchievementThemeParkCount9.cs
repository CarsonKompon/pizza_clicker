using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementThemeParkCount9 : Achievement
{
	public override string Ident => "building_08_theme_park_count_09";
	public override string Name => "Ride the slice";
	public override string Description => "Purchase 400 Pizza Theme Parks";
	public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) / 400d;
	}
}
