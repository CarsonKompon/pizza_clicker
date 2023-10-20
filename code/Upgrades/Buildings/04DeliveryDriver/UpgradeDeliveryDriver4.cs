using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeDeliveryDriver4 : Upgrade
{
	public override string Ident => "upgrade_delivery_driver_4";
	public override string Name => "Prismatic Delivery Driver";
	public override string Description => "Delivery Drivers are twice as effective";
	public override double Cost => 600_000_000;
	public override string Icon => "ui/upgrades/delivery_driver_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "delivery_driver", 2 );
	}
}
