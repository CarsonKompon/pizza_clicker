using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount9 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_09";
	public override string Name => "Effervescent empire";
	public override string Description => "Purchase 400 Soda Fountain Factories";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 400;
	}
}
