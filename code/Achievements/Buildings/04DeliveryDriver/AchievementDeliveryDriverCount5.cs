using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount5 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_05";
	public override string Name => "Ride or Pie";
	public override string Description => "Purchase 200 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 200;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) / 200d;
	}
}
