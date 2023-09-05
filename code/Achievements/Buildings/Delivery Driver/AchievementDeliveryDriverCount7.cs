using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementDeliveryDriverCount7 : Achievement
{
    public override string Ident => "building_3_delivery_driver_count_07";
    public override string Name => "300 miles and running";
    public override string Description => "Purchase 300 Delivery Drivers";
    public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("delivery_driver") >= 300;
	}

}

