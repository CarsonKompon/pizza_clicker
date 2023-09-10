using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzaGPTCount1 : Achievement
{
    public override string Ident => "building_12_pizza_gpt_count_01";
    public override string Name => "First words";
    public override string Description => "Purchase 1 PizzaGPT";
    public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_gpt") >= 1;
	}

}

