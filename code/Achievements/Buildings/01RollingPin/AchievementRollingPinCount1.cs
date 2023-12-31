using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementRollingPinCount1 : Achievement
{
	public override string Ident => "building_01_rolling_pin_count_01";
	public override string Name => "Rolling rolling rolling...";
	public override string Description => "Purchase 1 Rolling Pin";
	public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) >= 1;
	}
}
