using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeInterdimensional7 : Upgrade
{
	public override string Ident => "upgrade_interdimensional_7";
	public override string Name => "Silver Multiverse Pizza Hub";
	public override string Description => "Interdimensional Pizzerias are twice as effective";
	public override double Cost => double.Parse( "85,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/multiverse_hub_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 200;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "interdimensional_pizzeria", 2 );
	}
}
