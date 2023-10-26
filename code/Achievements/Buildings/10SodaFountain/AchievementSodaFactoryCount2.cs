using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount2 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_02";
	public override string Name => "Fountain of youth";
	public override string Description => "Purchase 50 Soda Fountain Factories";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) / 50d;
	}
}
