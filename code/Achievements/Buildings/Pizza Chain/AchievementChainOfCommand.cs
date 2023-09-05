using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementChainOfCommand : Achievement
{
    public override string Ident => "building_pizza_chain_count_2";
    public override string Name => "Chain of command";
    public override string Description => "Purchase 50 Pizza Chains";
    public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_chain") >= 50;
	}

}

