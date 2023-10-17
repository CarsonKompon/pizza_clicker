using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount3 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_03";
	public override string Name => "Speedy centenarian";
	public override string Description => "Purchase 100 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 100;
	}
}
