using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount1 : Achievement
{
	public override string Ident => "building_03_oven_count_01";
	public override string Name => "Easy Bake";
	public override string Description => "Purchase 1 Oven";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 1;
	}
}
