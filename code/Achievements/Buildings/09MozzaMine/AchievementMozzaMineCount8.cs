using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementMozzaMineCount8 : Achievement
{
	public override string Ident => "building_09_mozza_mine_count_08";
	public override string Name => "Cave aged";
	public override string Description => "Purchase 350 Mozzarella Mines";
	public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) >= 350;
	}
}
