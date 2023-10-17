using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaChain8 : Upgrade
{
	public override string Ident => "upgrade_pizza_chain_8";
	public override string Name => "Gold Pizza Restaurant";
	public override string Description => "Pizza Chains are twice as effective";
	public override double Cost => double.Parse( "65,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_restaurant_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 250;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_chain", 2 );
	}
}
