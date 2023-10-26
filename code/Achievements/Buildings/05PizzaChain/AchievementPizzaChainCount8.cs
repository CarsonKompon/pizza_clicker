using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaChainCount8 : Achievement
{
	public override string Ident => "building_05_pizza_chain_count_08";
	public override string Name => "Tri-generational franchise";
	public override string Description => "Purchase 350 Pizza Chains";
	public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) / 350d;
	}
}
