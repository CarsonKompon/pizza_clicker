using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeFederation7 : Upgrade
{
	public override string Ident => "upgrade_pizza_federation_7";
	public override string Name => "Silver United Federation";
	public override string Description => "Pizza Federations are twice as effective";
	public override double Cost => double.Parse( "155,000,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/united_federation_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 200;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_federation", 2 );
	}
}
