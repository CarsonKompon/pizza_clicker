using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUniversityCount2 : Achievement
{
	public override string Ident => "building_11_university_count_02";
	public override string Name => "Honour roll";
	public override string Description => "Purchase 50 Pizza Universities";
	public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) / 50d;
	}
}
