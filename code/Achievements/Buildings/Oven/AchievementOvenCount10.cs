using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementOvenCount10 : Achievement
{
    public override string Ident => "building_3_oven_count_10";
    public override string Name => "Farhenheit 450";
    public override string Description => "Purchase 450 Ovens";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 450;
	}

}

