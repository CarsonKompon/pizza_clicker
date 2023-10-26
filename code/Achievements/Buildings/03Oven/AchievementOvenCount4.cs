using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount4 : Achievement
{
	public override string Ident => "building_03_oven_count_04";
	public override string Name => "Hell's Kitchen";
	public override string Description => "Purchase 150 Ovens";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 150;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "oven" ) / 150d;
	}
}
