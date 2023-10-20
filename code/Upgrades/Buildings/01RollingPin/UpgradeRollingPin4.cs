using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeRollingPin4 : Upgrade
{
	public override string Ident => "upgrade_rolling_pin_4";
	public override string Name => "Prismatic Rolling Pin";
	public override string Description => "Rolling Pins are twice as effective";
	public override double Cost => 100_000;
	public override string Icon => "ui/upgrades/rolling_pin_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "rolling_pin", 2 );
	}
}
