using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementQuantumColliderCount10 : Achievement
{
	public override string Ident => "building_15_quantum_collider_count_10";
	public override string Name => "Planck's pizza constant";
	public override string Description => "Purchase 450 Quantum Pizza Colliders";
	public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 450;
	}
}
