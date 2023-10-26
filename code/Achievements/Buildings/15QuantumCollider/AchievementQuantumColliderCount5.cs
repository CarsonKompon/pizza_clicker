using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementQuantumColliderCount5 : Achievement
{
	public override string Ident => "building_15_quantum_collider_count_05";
	public override string Name => "Subatomic saucery";
	public override string Description => "Purchase 200 Quantum Pizza Colliders";
	public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 200;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) / 200d;
	}
}
