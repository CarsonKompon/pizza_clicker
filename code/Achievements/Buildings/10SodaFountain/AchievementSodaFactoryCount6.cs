using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount6 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_06";
	public override string Name => "Sweet success";
	public override string Description => "Purchase 250 Soda Fountain Factories";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) / 250d;
	}
}
