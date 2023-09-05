using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSauceBreweryCount1 : Achievement
{
    public override string Ident => "building_6_sauce_brewery_count_01";
    public override string Name => "Saucy start";
    public override string Description => "Purchase 1 Sauce Brewery";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("sauce_brewery") >= 1;
	}

}

