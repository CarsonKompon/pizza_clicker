using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeOven4 : Upgrade
{
	public override string Ident => "upgrade_oven_4";
	public override string Name => "Prismatic Oven";
	public override string Description => "Ovens are twice as effective";
	public override double Cost => 55_000_000;
	public override string Icon => "ui/upgrades/oven_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "oven", 2 );
	}
}
