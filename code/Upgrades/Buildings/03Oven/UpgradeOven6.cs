using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeOven6 : Upgrade
{
	public override string Ident => "upgrade_oven_6";
	public override string Name => "Bronze Brick Oven";
	public override string Description => "Ovens are twice as effective";
	public override double Cost => 550_000_000_000;
	public override string Icon => "ui/upgrades/brick_oven_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "oven", 2 );
	}
}
