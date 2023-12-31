using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount3 : Achievement
{
	public override string Ident => "building_03_oven_count_03";
	public override string Name => "CentiCrisp";
	public override string Description => "Purchase 100 Ovens";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 100;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "oven" ) / 100d;
	}
}
