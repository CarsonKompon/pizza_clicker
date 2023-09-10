using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementThemeParkCount10 : Achievement
{
    public override string Ident => "building_08_theme_park_count_10";
    public override string Name => "Boardwalk monopoly";
    public override string Description => "Purchase 450 Pizza Theme Parks";
    public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_theme_park") >= 450;
	}

}

