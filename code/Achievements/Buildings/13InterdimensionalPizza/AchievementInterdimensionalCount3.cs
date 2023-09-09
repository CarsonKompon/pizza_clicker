using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInterdimensionalCount3 : Achievement
{
    public override string Ident => "building_13_interdimensional_count_03";
    public override string Name => "Portal pepperoni";
    public override string Description => "Purchase 100 Interdimensional Pizzerias";
    public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("interdimensional_pizzeria") >= 100;
	}

}

