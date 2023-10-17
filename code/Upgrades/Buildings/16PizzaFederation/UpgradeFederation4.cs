using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeFederation4 : Upgrade
{
	public override string Ident => "upgrade_pizza_federation_4";
	public override string Name => "Prismatic Pizza Federation";
	public override string Description => "Pizza Federations are twice as effective";
	public override double Cost => double.Parse( "15,500,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_federation_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_federation", 2 );
	}
}
