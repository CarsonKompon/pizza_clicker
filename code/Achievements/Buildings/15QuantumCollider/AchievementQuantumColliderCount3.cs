using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementQuantumColliderCount3 : Achievement
{
    public override string Ident => "building_15_quantum_collider_count_03";
    public override string Name => "Quantum leap of flavour";
    public override string Description => "Purchase 100 Quantum Pizza Colliders";
    public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("quantum_pizza_collider") >= 100;
	}

}

