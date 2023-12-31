using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount9 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_09";
	public override string Name => "Speed limit";
	public override string Description => "Purchase 400 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) / 400d;
	}
}
