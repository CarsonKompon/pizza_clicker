using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount10 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_10";
	public override string Name => "Cola conqueror";
	public override string Description => "Purchase 450 Soda Fountain Factories";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 450;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) / 450d;
	}
}
