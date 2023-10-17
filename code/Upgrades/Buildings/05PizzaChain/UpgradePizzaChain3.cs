using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaChain3 : Upgrade
{
	public override string Ident => "upgrade_pizza_chain_3";
	public override string Name => "Gold Pizza Chain";
	public override string Description => "Pizza Chains are twice as effective";
	public override double Cost => 65_000_000;
	public override string Icon => "ui/upgrades/pizza_chain_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_chain", 2 );
	}
}
