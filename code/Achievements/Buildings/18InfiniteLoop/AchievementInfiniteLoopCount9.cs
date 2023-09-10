using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInfiniteLoopCount9 : Achievement
{
    public override string Ident => "building_18_infinite_loop_count_09";
    public override string Name => "Infinite cravings";
    public override string Description => "Purchase 400 Infinite Pizza Loops";
    public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("infinite_pizza_loop") >= 400;
	}

}

