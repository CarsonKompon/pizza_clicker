using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaChainCount1 : Achievement
{
	public override string Ident => "building_05_pizza_chain_count_01";
	public override string Name => "Business is booming!";
	public override string Description => "Purchase 1 Pizza Chain";
	public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 1;
	}
}
