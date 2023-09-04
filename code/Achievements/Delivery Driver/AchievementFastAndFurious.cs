using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementFastAndFurious : Achievement
{
    public override string Ident => "building_delivery_driver_count_2";
    public override string Name => "Fast and Furious";
    public override string Description => "Purchase 50 Delivery Drivers";
    public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("delivery_driver") >= 50;
	}

}

