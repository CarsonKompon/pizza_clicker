using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementQuantumColliderCount7 : Achievement
{
	public override string Ident => "building_15_quantum_collider_count_07";
	public override string Name => "Wave-particle pizzalarity";
	public override string Description => "Purchase 300 Quantum Pizza Colliders";
	public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 300;
	}
}
