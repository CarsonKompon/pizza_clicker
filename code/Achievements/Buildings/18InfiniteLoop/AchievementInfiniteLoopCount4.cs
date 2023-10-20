using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount4 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_04";
	public override string Name => "Temporal toppings";
	public override string Description => "Purchase 150 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 150;
	}
}
