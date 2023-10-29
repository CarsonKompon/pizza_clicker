using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementOvenCount11 : Achievement
{
	public override string Ident => "building_03_oven_count_11";
	public override string Name => "Ovens for the Ages";
	public override string Description => "Purchase 500 Ovens";
	public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "oven" ) >= 500;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "oven" ) / 500d;
	}
}
