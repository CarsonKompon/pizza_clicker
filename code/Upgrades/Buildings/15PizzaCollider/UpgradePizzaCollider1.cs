using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaCollider1 : Upgrade
{
	public override string Ident => "upgrade_pizza_collider_1";
	public override string Name => "Bronze Quantum Pizza Collider";
	public override string Description => "Quantum Pizza Colliders are twice as effective";
	public override double Cost => 260_000_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_collider_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 1;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "quantum_pizza_collider", 2 );
	}
}
