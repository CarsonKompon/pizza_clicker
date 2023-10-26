using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaChainCount5 : Achievement
{
	public override string Ident => "building_05_pizza_chain_count_05";
	public override string Name => "Link by link";
	public override string Description => "Purchase 200 Pizza Chains";
	public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 200;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) / 200d;
	}
}
