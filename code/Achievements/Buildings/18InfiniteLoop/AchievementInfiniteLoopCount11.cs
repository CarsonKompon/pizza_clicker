using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementInfiniteLoopCount11 : Achievement
{
    public override string Ident => "building_18_infinite_loop_count_11";
    public override string Name => "The unending feast";
    public override string Description => "Purchase 500 Infinite Pizza Loops";
    public override string Icon => "/ui/buildings/infinite_pizza_loop.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("infinite_pizza_loop") >= 500;
	}

}

