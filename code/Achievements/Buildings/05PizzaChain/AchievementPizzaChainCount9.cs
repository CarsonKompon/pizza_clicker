using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaChainCount9 : Achievement
{
	public override string Ident => "building_05_pizza_chain_count_09";
	public override string Name => "Monopoly";
	public override string Description => "Purchase 400 Pizza Chains";
	public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) / 400d;
	}
}
