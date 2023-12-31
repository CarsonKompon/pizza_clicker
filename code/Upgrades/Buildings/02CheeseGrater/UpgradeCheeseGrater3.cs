using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeCheeseGrater3 : Upgrade
{
	public override string Ident => "upgrade_cheese_grater_3";
	public override string Name => "Gold Cheese Grater";
	public override string Description => "Cheese Graters are twice as effective";
	public override double Cost => 50_000;
	public override string Icon => "ui/upgrades/cheese_grater_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "cheese_grater", 2 );
	}
}
