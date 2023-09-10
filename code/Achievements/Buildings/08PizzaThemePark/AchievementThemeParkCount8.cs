using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementThemeParkCount8 : Achievement
{
    public override string Ident => "building_08_theme_park_count_08";
    public override string Name => "Adrenaline and marinara";
    public override string Description => "Purchase 350 Pizza Theme Parks";
    public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_theme_park") >= 350;
	}

}

