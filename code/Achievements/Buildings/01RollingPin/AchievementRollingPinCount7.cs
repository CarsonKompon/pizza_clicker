using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingPinCount7 : Achievement
{
    public override string Ident => "building_01_rolling_pin_count_07";
    public override string Name => "Roll model";
    public override string Description => "Purchase 300 Rolling Pins";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("rolling_pin") >= 300;
	}

}

