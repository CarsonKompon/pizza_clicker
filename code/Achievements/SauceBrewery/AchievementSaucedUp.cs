using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSaucedUp : Achievement
{
    public override string Ident => "building_sauce_brewery_count_2";
    public override string Name => "Sauced up";
    public override string Description => "Purchase 50 Sauce Brewerys";
    public override string Icon => "/ui/buildings/sauce_brewery.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("sauce_brewery") >= 50;
	}

}

