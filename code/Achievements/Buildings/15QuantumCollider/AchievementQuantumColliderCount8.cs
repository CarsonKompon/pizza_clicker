using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementQuantumColliderCount8 : Achievement
{
    public override string Ident => "building_15_quantum_collider_count_08";
    public override string Name => "Cheese entanglement";
    public override string Description => "Purchase 350 Quantum Pizza Colliders";
    public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("quantum_pizza_collider") >= 350;
	}

}

