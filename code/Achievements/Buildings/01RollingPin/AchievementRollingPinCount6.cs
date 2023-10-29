using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementRollingPinCount6 : Achievement
{
	public override string Ident => "building_01_rolling_pin_count_06";
	public override string Name => "Two-fifty tumbler";
	public override string Description => "Purchase 250 Rolling Pins";
	public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) / 250d;
	}
}
