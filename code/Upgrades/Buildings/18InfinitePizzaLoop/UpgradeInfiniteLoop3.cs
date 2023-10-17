using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeInfiniteLoop3 : Upgrade
{
	public override string Ident => "upgrade_pizza_loop_3";
	public override string Name => "Gold Infinite Pizza Loop";
	public override string Description => "Infinite Pizza Loops are twice as effective";
	public override double Cost => double.Parse( "6,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_loop_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "infinite_pizza_loop" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "infinite_pizza_loop", 2 );
	}
}
