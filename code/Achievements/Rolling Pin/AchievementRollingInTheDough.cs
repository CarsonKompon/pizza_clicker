using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingInTheDough : Achievement
{
    public override string Ident => "rolling_in_the_dough";
    public override string Name => "Rolling in the dough";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("rolling_pin") >= 50;
	}

}

