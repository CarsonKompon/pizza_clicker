using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementCheeseGraterCount6 : Achievement
{
	public override string Ident => "building_02_cheese_grater_count_06";
	public override string Name => "Cheese Mountain";
	public override string Description => "Purchase 250 Cheese Graters";
	public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) / 250d;
	}
}
