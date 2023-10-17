using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeInterdimensional3 : Upgrade
{
	public override string Ident => "upgrade_interdimensional_3";
	public override string Name => "Gold Interdimensional Pizzeria";
	public override string Description => "Interdimensional Pizzerias are twice as effective";
	public override double Cost => 85_000_000_000_000_000;
	public override string Icon => "ui/upgrades/interdimensional_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "interdimensional_pizzeria", 2 );
	}
}
