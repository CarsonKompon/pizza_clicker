using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount8 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_08";
	public override string Name => "High-octane delivery";
	public override string Description => "Purchase 350 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 350;
	}
}
