using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount3 : Achievement
{
    public override string Ident => "building_02_cheese_grater_count_03";
    public override string Name => "Cheddar by the Hundreds";
    public override string Description => "Purchase 100 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("cheese_grater") >= 100;
	}

}

