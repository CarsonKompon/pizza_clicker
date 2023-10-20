using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaChain4 : Upgrade
{
	public override string Ident => "upgrade_pizza_chain_4";
	public override string Name => "Prismatic Pizza Chain";
	public override string Description => "Pizza Chains are twice as effective";
	public override double Cost => 6_500_000_000;
	public override string Icon => "ui/upgrades/pizza_chain_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_chain" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_chain", 2 );
	}
}
