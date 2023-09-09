using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementQuantumColliderCount6 : Achievement
{
    public override string Ident => "building_15_quantum_collider_count_06";
    public override string Name => "Quantum culinary computing";
    public override string Description => "Purchase 250 Quantum Pizza Colliders";
    public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("quantum_pizza_collider") >= 250;
	}

}

