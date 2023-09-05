using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementHellsKitchen : Achievement
{
    public override string Ident => "building_oven_count_3";
    public override string Name => "Hell's Kitchen";
    public override string Description => "Purchase 250 Ovens";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 250;
	}

}

