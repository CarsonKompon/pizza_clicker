using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeCheeseGrater4 : Upgrade
{
	public override string Ident => "upgrade_cheese_grater_4";
	public override string Name => "Prismatic Cheese Grater";
	public override string Description => "Cheese Graters are twice as effective";
	public override double Cost => 5_000_000;
	public override string Icon => "ui/upgrades/cheese_grater_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "cheese_grater", 2 );
	}
}
