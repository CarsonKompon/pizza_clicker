using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementDeliveryDriverCount5 : Achievement
{
    public override string Ident => "building_03_delivery_driver_count_05";
    public override string Name => "Ride or Pie";
    public override string Description => "Purchase 200 Delivery Drivers";
    public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("delivery_driver") >= 200;
	}

}

