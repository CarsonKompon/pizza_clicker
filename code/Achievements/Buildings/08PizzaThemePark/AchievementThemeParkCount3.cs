using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementThemeParkCount3 : Achievement
{
	public override string Ident => "building_08_theme_park_count_03";
	public override string Name => "Park and ride";
	public override string Description => "Purchase 100 Pizza Theme Parks";
	public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 100;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) / 100d;
	}
}
