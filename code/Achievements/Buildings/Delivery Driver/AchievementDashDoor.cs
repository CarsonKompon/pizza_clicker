using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementDashDoor : Achievement
{
    public override string Ident => "building_delivery_driver_count_1";
    public override string Name => "DashDoor";
    public override string Description => "Purchase 1 Delivery Driver";
    public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("delivery_driver") >= 1;
	}

}

