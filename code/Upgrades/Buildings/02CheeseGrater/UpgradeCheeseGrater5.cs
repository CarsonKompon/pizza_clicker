using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeCheeseGrater5 : Upgrade
{
	public override string Ident => "upgrade_cheese_grater_5";
	public override string Name => "Hydraulic Cheese Shredder";
	public override string Description => "Cheese Graters are twice as effective";
	public override double Cost => 500_000_000;
	public override string Icon => "ui/upgrades/cheese_shredder.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 100;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "cheese_grater", 2 );
	}
}
