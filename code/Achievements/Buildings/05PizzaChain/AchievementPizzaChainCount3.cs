using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaChainCount3 : Achievement
{
    public override string Ident => "building_05_pizza_chain_count_03";
    public override string Name => "Chain reaction";
    public override string Description => "Purchase 100 Pizza Chains";
    public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_chain") >= 100;
	}

}

