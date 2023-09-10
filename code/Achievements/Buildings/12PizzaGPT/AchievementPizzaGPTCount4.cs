using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaGPTCount4 : Achievement
{
    public override string Ident => "building_12_pizza_gpt_count_04";
    public override string Name => "Algorithmic pizza";
    public override string Description => "Purchase 150 PizzaGPTs";
    public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_gpt") >= 150;
	}

}

