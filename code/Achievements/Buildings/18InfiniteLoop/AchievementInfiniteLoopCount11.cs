using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount11 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_11";
	public override string Name => "The unending feast";
	public override string Description => "Purchase 500 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 500;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) / 500d;
	}
}
