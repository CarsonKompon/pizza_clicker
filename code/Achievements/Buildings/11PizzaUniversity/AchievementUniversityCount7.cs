using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUniversityCount7 : Achievement
{
	public override string Ident => "building_11_university_count_07";
	public override string Name => "The upper crust";
	public override string Description => "Purchase 300 Pizza Universities";
	public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 300;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) / 300d;
	}
}
