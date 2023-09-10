using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSauceBreweryCount5 : Achievement
{
    public override string Ident => "building_06_sauce_brewery_count_05";
    public override string Name => "Sauce Harbor";
    public override string Description => "Purchase 200 Sauce Brewerys";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("sauce_brewery") >= 200;
	}

}

