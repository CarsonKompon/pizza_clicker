using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementThemeParkCount5 : Achievement
{
	public override string Ident => "building_08_theme_park_count_05";
	public override string Name => "The cheesiest place on earth";
	public override string Description => "Purchase 200 Pizza Theme Parks";
	public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 200;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) / 200d;
	}
}
