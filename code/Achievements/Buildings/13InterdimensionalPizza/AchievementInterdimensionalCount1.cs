using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInterdimensionalCount1 : Achievement
{
    public override string Ident => "building_13_interdimensional_count_01";
    public override string Name => "Dimensional dining";
    public override string Description => "Purchase 1 Interdimensional Pizzeria";
    public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("interdimensional_pizzeria") >= 1;
	}

}

