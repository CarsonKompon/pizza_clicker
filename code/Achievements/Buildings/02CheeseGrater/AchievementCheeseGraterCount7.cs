using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementCheeseGraterCount7 : Achievement
{
	public override string Ident => "building_02_cheese_grater_count_07";
	public override string Name => "Three cheese moon";
	public override string Description => "Purchase 300 Cheese Graters";
	public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 300;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) / 300d;
	}
}
