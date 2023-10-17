using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementQuantumColliderCount9 : Achievement
{
	public override string Ident => "building_15_quantum_collider_count_09";
	public override string Name => "Pizza singularity";
	public override string Description => "Purchase 400 Quantum Pizza Colliders";
	public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 400;
	}
}
