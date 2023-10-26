using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount9 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_09";
	public override string Name => "Infinite cravings";
	public override string Description => "Purchase 400 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) / 400d;
	}
}
