using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaChainCount4 : Achievement
{
	public override string Ident => "building_05_pizza_chain_count_04";
	public override string Name => "A chain unbroken";
	public override string Description => "Purchase 150 Pizza Chains";
	public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) / 150d;
	}
}
