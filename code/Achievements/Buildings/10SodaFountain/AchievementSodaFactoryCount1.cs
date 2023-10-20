using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount1 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_01";
	public override string Name => "Soda jerk";
	public override string Description => "Purchase 1 Soda Fountain Factory";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 1;
	}
}
