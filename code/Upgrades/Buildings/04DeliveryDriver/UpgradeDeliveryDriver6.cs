using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeDeliveryDriver6 : Upgrade
{
	public override string Ident => "upgrade_delivery_driver_6";
	public override string Name => "Bronze Pizza Truck";
	public override string Description => "Delivery Drivers are twice as effective";
	public override double Cost => 6_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_truck_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "delivery_driver", 2 );
	}
}
