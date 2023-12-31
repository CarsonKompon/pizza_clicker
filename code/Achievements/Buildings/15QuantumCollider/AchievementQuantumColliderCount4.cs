using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementQuantumColliderCount4 : Achievement
{
	public override string Ident => "building_15_quantum_collider_count_04";
	public override string Name => "Unifying theory of toppings";
	public override string Description => "Purchase 150 Quantum Pizza Colliders";
	public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "quantum_pizza_collider" ) / 150d;
	}
}
