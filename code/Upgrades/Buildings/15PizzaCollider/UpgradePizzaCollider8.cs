using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaCollider8 : Upgrade
{
	public override string Ident => "upgrade_pizza_collider_8";
	public override string Name => "Gold Hadron Collider";
	public override string Description => "Quantum Pizza Colliders are twice as effective";
	public override double Cost => double.Parse( "13,000,000,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_hadron_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 250;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "quantum_pizza_collider", 2 );
	}
}
