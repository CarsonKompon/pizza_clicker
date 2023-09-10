using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount4 : Achievement
{
    public override string Ident => "building_02_cheese_grater_count_04";
    public override string Name => "Grater good";
    public override string Description => "Purchase 150 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("cheese_grater") >= 150;
	}

}

