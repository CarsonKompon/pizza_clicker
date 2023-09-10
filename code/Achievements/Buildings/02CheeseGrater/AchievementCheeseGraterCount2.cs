using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount2 : Achievement
{
    public override string Ident => "building_02_cheese_grater_count_02";
    public override string Name => "Grate expectations";
    public override string Description => "Purchase 50 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("cheese_grater") >= 50;
	}

}

