using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInfiniteLoopCount8 : Achievement
{
	public override string Ident => "building_18_infinite_loop_count_08";
	public override string Name => "Eternity and a day";
	public override string Description => "Purchase 350 Infinite Pizza Loops";
	public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) / 350d;
	}
}
