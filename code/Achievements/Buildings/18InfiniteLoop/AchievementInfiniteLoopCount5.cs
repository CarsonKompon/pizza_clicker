using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount5 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_05";
	public override string Name => "Causal culinary chain";
	public override string Description => "Purchase 200 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 200;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) / 200d;
	}
}
