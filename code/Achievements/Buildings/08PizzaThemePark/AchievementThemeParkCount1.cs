using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementThemeParkCount1 : Achievement
{
    public override string Ident => "building_08_theme_park_count_01";
    public override string Name => "Fun and flour";
    public override string Description => "Purchase 1 Pizza Theme Park";
    public override string Icon => "/ui/buildings/pizza_theme_park.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("pizza_theme_park") >= 1;
	}

}

