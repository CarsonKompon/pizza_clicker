using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInfiniteLoopCount7 : Achievement
{
    public override string Ident => "building_18_infinite_loop_count_07";
    public override string Name => "Ouroboros oven";
    public override string Description => "Purchase 300 Infinite Pizza Loops";
    public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("infinite_pizza_loop") >= 300;
	}

}

