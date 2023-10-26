using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount6 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_06";
	public override string Name => "Timeless taste";
	public override string Description => "Purchase 250 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) / 250d;
	}
}
