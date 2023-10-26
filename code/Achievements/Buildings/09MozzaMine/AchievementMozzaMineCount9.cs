using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementMozzaMineCount9 : Achievement
{
	public override string Ident => "building_09_mozza_mine_count_09";
	public override string Name => "The miner leagues";
	public override string Description => "Purchase 400 Mozzarella Mines";
	public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) / 400d;
	}
}
