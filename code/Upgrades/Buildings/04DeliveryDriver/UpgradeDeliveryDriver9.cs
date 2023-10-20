using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeDeliveryDriver9 : Upgrade
{
	public override string Ident => "upgrade_delivery_driver_9";
	public override string Name => "Prismatic Pizza Truck";
	public override string Description => "Delivery Drivers are twice as effective";
	public override double Cost => double.Parse( "6,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_truck_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 300;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "delivery_driver", 2 );
	}
}
