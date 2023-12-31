using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementThemeParkCount10 : Achievement
{
	public override string Ident => "building_08_theme_park_count_10";
	public override string Name => "Boardwalk monopoly";
	public override string Description => "Purchase 450 Pizza Theme Parks";
	public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 450;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) / 450d;
	}
}
