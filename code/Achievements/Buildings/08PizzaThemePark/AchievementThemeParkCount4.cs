using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementThemeParkCount4 : Achievement
{
	public override string Ident => "building_08_theme_park_count_04";
	public override string Name => "E-Ticket eats";
	public override string Description => "Purchase 150 Pizza Theme Parks";
	public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) / 150d;
	}
}
