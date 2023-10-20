using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount10 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_10";
	public override string Name => "Speed limit";
	public override string Description => "Purchase 450 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 450;
	}
}

