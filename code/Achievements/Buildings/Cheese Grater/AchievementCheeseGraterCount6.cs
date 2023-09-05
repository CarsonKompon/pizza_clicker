using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount6 : Achievement
{
    public override string Ident => "building_2_cheese_grater_count_06";
    public override string Name => "Cheese Mountain";
    public override string Description => "Purchase 250 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("cheese_grater") >= 250;
	}

}

