using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSauceBreweryCount3 : Achievement
{
    public override string Ident => "building_6_sauce_brewery_count_03";
    public override string Name => "Saucy centurion";
    public override string Description => "Purchase 100 Sauce Brewerys";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("sauce_brewery") >= 100;
	}

}

