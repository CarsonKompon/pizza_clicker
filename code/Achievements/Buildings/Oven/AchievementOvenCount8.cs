using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementOvenCount8 : Achievement
{
    public override string Ident => "building_3_oven_count_08";
    public override string Name => "The 350th element";
    public override string Description => "Purchase 350 Ovens";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 350;
	}

}

