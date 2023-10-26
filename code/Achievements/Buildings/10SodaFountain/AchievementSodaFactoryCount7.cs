using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount7 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_07";
	public override string Name => "Carbonated Kinpin";
	public override string Description => "Purchase 300 Soda Fountain Factories";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 300;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) / 300d;
	}
}
