using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount2 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_02";
	public override string Name => "Pizza paradox";
	public override string Description => "Purchase 50 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 50;
	}
}
