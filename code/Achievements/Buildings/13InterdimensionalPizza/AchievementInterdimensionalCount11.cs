using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInterdimensionalCount11 : Achievement
{
    public override string Ident => "building_13_interdimensional_count_11";
    public override string Name => "Universal flavour contest";
    public override string Description => "Purchase 500 Interdimensional Pizzerias";
    public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("interdimensional_pizzeria") >= 500;
	}

}

