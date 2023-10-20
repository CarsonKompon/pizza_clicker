using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUniversityCount1 : Achievement
{
	public override string Ident => "building_11_university_count_01";
	public override string Name => "Freshman fifteen";
	public override string Description => "Purchase 1 Pizza University";
	public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 1;
	}
}
