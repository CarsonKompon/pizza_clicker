using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaGPTCount10 : Achievement
{
    public override string Ident => "building_12_pizza_gpt_count_10";
    public override string Name => "Self-taught, self-sliced";
    public override string Description => "Purchase 450 PizzaGPTs";
    public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_gpt") >= 450;
	}

}

