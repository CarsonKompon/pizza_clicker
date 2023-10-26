using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount6 : Achievement
{
	public override string Ident => "building_03_oven_count_06";
	public override string Name => "The Ovenator";
	public override string Description => "Purchase 250 Ovens";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "oven" ) / 250d;
	}
}
