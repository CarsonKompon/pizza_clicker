using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeOven9 : Upgrade
{
	public override string Ident => "upgrade_oven_9";
	public override string Name => "Rainbow Brick Oven";
	public override string Description => "Ovens are twice as effective";
	public override double Cost => 550_000_000_000_000_000;
	public override string Icon => "ui/upgrades/brick_oven_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 300;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "oven", 2 );
	}
}
