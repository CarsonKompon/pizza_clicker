using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount9 : Achievement
{
	public override string Ident => "building_03_oven_count_09";
	public override string Name => "400 degrees of freedom";
	public override string Description => "Purchase 400 Ovens";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 400;
	}
}
