using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementRolling : Achievement
{
    public override string Ident => "building_rolling_pin_count_1";
    public override string Name => "Rolling rolling rolling...";
    public override string Description => "Purchase 1 Rolling Pin";
    public override string Icon => "/ui/buildings/rolling_pin.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("rolling_pin") >= 1;
	}

}

