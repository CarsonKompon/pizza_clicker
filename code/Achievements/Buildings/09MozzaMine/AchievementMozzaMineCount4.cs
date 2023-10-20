using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementMozzaMineCount4 : Achievement
{
	public override string Ident => "building_09_mozza_mine_count_04";
	public override string Name => "The cheesiest crust";
	public override string Description => "Purchase 150 Mozzarella Mines";
	public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) >= 150;
	}
}
