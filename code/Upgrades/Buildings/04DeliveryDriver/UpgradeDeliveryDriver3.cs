using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeDeliveryDriver3 : Upgrade
{
	public override string Ident => "upgrade_delivery_driver_3";
	public override string Name => "Gold Delivery Driver";
	public override string Description => "Delivery Drivers are twice as effective";
	public override double Cost => 6_000_000;
	public override string Icon => "ui/upgrades/delivery_driver_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "delivery_driver", 2 );
	}
}
