using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingPinCount10 : Achievement
{
    public override string Ident => "building_01_rolling_pin_count_10";
    public override string Name => "Rolling stones";
    public override string Description => "Purchase 450 Rolling Pins";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("rolling_pin") >= 450;
	}

}

