using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeRollingPin9 : Upgrade
{
	public override string Ident => "upgrade_rolling_pin_9";
	public override string Name => "Prismatic Pizza Sheeter";
	public override string Description => "Rolling Pins are twice as effective";
	public override double Cost => 10_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_sheeter_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) >= 250;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "rolling_pin", 2 );
	}
}
