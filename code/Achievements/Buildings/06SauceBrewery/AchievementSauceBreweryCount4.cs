using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSauceBreweryCount4 : Achievement
{
    public override string Ident => "building_06_sauce_brewery_count_04";
    public override string Name => "Big brew";
    public override string Description => "Purchase 150 Sauce Brewerys";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("sauce_brewery") >= 150;
	}

}

