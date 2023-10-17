using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeOven2 : Upgrade
{
	public override string Ident => "upgrade_oven_2";
	public override string Name => "Silver Oven";
	public override string Description => "Ovens are twice as effective";
	public override double Cost => 55_000;
	public override string Icon => "ui/upgrades/oven_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 5;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "oven", 2 );
	}
}
