using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount6 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_06";
	public override string Name => "Cruise control";
	public override string Description => "Purchase 250 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) / 250d;
	}
}
