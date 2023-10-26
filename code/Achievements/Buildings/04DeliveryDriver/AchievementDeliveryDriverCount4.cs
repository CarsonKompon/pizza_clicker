using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementDeliveryDriverCount4 : Achievement
{
	public override string Ident => "building_03_delivery_driver_count_04";
	public override string Name => "Fast lane";
	public override string Description => "Purchase 150 Delivery Drivers";
	public override string Icon => "/ui/buildings/delivery_driver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "delivery_driver" ) / 150d;
	}
}
