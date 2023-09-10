using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementOvenCount7 : Achievement
{
    public override string Ident => "building_03_oven_count_07";
    public override string Name => "Oven Trinity";
    public override string Description => "Purchase 300 Ovens";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("oven") >= 300;
	}

}

