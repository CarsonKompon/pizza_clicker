using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementOvenCount5 : Achievement
{
    public override string Ident => "building_3_oven_count_05";
    public override string Name => "Convection Perfection";
    public override string Description => "Purchase 200 Ovens";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 200;
	}

}

