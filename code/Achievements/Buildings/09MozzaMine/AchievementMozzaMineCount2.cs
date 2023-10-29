using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementMozzaMineCount2 : Achievement
{
	public override string Ident => "building_09_mozza_mine_count_02";
	public override string Name => "Digging the flavour";
	public override string Description => "Purchase 50 Mozzarella Mines";
	public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) / 50d;
	}
}
