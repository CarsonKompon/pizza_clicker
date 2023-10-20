using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeCheeseGrater7 : Upgrade
{
	public override string Ident => "upgrade_cheese_grater_7";
	public override string Name => "Silver Cheese Shredder";
	public override string Description => "Cheese Graters are twice as effective";
	public override double Cost => 50_000_000_000_000;
	public override string Icon => "ui/upgrades/cheese_shredder_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 200;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "cheese_grater", 2 );
	}
}
