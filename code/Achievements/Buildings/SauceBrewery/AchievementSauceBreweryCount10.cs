using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSauceBreweryCount10 : Achievement
{
    public override string Ident => "building_6_sauce_brewery_count_10";
    public override string Name => "Approaching sauce nirvana";
    public override string Description => "Purchase 450 Sauce Brewerys";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("sauce_brewery") >= 450;
	}

}

