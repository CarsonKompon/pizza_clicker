using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementQuantumColliderCount1 : Achievement
{
    public override string Ident => "building_15_quantum_collider_count_01";
    public override string Name => "Schrödinger's Slice";
    public override string Description => "Purchase 1 Quantum Pizza Collider";
    public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("quantum_pizza_collider") >= 1;
	}

}

