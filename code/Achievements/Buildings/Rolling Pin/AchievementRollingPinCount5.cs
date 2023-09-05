using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRollingPinCount5 : Achievement
{
    public override string Ident => "building_1_rolling_pin_count_05";
    public override string Name => "Double century spin";
    public override string Description => "Purchase 200 Rolling Pins";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("rolling_pin") >= 200;
	}

}

