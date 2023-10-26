using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount2 : Achievement
{
	public override string Ident => "building_03_oven_count_02";
	public override string Name => "Fifty Degrees of Crust";
	public override string Description => "Purchase 50 Ovens";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "oven" ) / 50d;
	}
}
