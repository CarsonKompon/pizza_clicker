using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount11 : Achievement
{
    public override string Ident => "building_2_cheese_grater_count_11";
    public override string Name => "The Ultimate Grate";
    public override string Description => "Purchase 500 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("cheese_grater") >= 500;
	}

}

