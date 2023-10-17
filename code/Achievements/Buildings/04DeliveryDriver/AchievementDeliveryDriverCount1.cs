using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount1 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_01";
	public override string Name => "DashDoor";
	public override string Description => "Purchase 1 Delivery Driver";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 1;
	}
}
