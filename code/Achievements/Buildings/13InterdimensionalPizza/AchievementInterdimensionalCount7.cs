using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInterdimensionalCount7 : Achievement
{
    public override string Ident => "building_13_interdimensional_count_07";
    public override string Name => "Spacethyme continuum";
    public override string Description => "Purchase 300 Interdimensional Pizzerias";
    public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("interdimensional_pizzeria") >= 300;
	}

}

