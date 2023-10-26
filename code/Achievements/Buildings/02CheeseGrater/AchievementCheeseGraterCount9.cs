using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementCheeseGraterCount9 : Achievement
{
	public override string Ident => "building_02_cheese_grater_count_09";
	public override string Name => "The Grate Wall of Cheese";
	public override string Description => "Purchase 400 Cheese Graters";
	public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) / 400d;
	}
}
