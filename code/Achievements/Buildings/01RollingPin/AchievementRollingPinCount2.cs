using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingPinCount2 : Achievement
{
    public override string Ident => "building_01_rolling_pin_count_02";
    public override string Name => "Rolling in the dough";
    public override string Description => "Purchase 50 Rolling Pins";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("rolling_pin") >= 50;
	}

}

