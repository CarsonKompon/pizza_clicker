using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaGPTCount7 : Achievement
{
    public override string Ident => "building_12_pizza_gpt_count_07";
    public override string Name => "Neural kneader";
    public override string Description => "Purchase 300 PizzaGPTs";
    public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_gpt") >= 300;
	}

}

