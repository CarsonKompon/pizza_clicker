using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementQuantumColliderCount2 : Achievement
{
    public override string Ident => "building_15_quantum_collider_count_02";
    public override string Name => "Quanta Collective";
    public override string Description => "Purchase 50 Quantum Pizza Colliders";
    public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("quantum_pizza_collider") >= 50;
	}

}

