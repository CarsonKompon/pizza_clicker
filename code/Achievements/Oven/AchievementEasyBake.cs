using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementEasyBake : Achievement
{
    public override string Ident => "easy_bake";
    public override string Name => "Easy Bake";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 1;
	}

}

