using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeRollingPin7 : Upgrade
{
	public override string Ident => "upgrade_rolling_pin_7";
	public override string Name => "Silver Pizza Sheeter";
	public override string Description => "Rolling Pins are twice as effective";
	public override double Cost => 1_000_000_000;
	public override string Icon => "ui/upgrades/pizza_sheeter_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "rolling_pin" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "rolling_pin", 2 );
	}
}
