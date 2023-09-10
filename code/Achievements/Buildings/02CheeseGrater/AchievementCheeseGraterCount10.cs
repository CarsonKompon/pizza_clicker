using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCheeseGraterCount10 : Achievement
{
    public override string Ident => "building_02_cheese_grater_count_10";
    public override string Name => "Close to grater perfection";
    public override string Description => "Purchase 450 Cheese Graters";
    public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("cheese_grater") >= 450;
	}

}

