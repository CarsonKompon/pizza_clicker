using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInfiniteLoopCount1 : Achievement
{
    public override string Ident => "building_18_infinite_loop_count_01";
    public override string Name => "Loop de loop";
    public override string Description => "Purchase 1 Infinite Pizza Loop";
    public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("infinite_pizza_loop") >= 1;
	}

}

