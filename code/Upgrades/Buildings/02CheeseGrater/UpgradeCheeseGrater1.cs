using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeCheeseGrater1 : Upgrade
{
	public override string Ident => "upgrade_cheese_grater_1";
	public override string Name => "Bronze Cheese Grater";
	public override string Description => "Cheese Graters are twice as effective";
	public override double Cost => 1_000;
	public override string Icon => "ui/upgrades/cheese_grater_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 1;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "cheese_grater", 2 );
	}
}
