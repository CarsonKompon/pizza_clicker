using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementThemeParkCount6 : Achievement
{
    public override string Ident => "building_08_theme_park_count_06";
    public override string Name => "Coaster crust";
    public override string Description => "Purchase 250 Pizza Theme Parks";
    public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_theme_park") >= 250;
	}

}

