using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeFederation8 : Upgrade
{
	public override string Ident => "upgrade_pizza_federation_8";
	public override string Name => "Gold United Federation";
	public override string Description => "Pizza Federations are twice as effective";
	public override double Cost => double.Parse( "155,000,000,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/united_federation_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 250;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_federation", 2 );
	}
}
