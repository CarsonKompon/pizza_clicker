using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementRollingPinCount9 : Achievement
{
	public override string Ident => "building_01_rolling_pin_count_09";
	public override string Name => "Roll of the titans";
	public override string Description => "Purchase 400 Rolling Pins";
	public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) / 400d;
	}
}
