using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSodaFactoryCount8 : Achievement
{
	public override string Ident => "building_10_soda_factory_count_08";
	public override string Name => "Drink and be merry";
	public override string Description => "Purchase 350 Soda Fountain Factories";
	public override string Icon => "/ui/buildings/soda_fountain_factory.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) / 350d;
	}
}
