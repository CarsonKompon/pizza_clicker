using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementQuantumColliderCount4 : Achievement
{
    public override string Ident => "building_15_quantum_collider_count_04";
    public override string Name => "Unifying theory of toppings";
    public override string Description => "Purchase 150 Quantum Pizza Colliders";
    public override string Icon => "/ui/buildings/quantum_pizza_collider.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("quantum_pizza_collider") >= 150;
	}

}

