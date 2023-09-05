using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSauceBreweryCount9 : Achievement
{
    public override string Ident => "building_6_sauce_brewery_count_09";
    public override string Name => "Brewmaster";
    public override string Description => "Purchase 400 Sauce Brewerys";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("sauce_brewery") >= 400;
	}

}

