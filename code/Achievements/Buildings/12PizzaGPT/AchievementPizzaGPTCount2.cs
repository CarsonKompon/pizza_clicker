using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaGPTCount2 : Achievement
{
    public override string Ident => "building_12_pizza_gpt_count_02";
    public override string Name => "Syntax and cheese";
    public override string Description => "Purchase 50 PizzaGPTs";
    public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_gpt") >= 50;
	}

}

