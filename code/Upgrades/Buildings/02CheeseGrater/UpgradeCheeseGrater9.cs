using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeCheeseGrater9 : Upgrade
{
	public override string Ident => "upgrade_cheese_grater_9";
	public override string Name => "Prismatic Cheese Shredder";
	public override string Description => "Cheese Graters are twice as effective";
	public override double Cost => double.Parse( "50,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/cheese_shredder_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 300;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "cheese_grater", 2 );
	}
}
