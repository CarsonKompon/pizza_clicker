using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementFastAndFurious : Achievement
{
    public override string Ident => "fast_and_furious";
    public override string Name => "Fast and Furious";
    public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("delivery_driver") >= 50;
	}

}

