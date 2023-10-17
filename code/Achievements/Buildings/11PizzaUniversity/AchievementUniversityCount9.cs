using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUniversityCount9 : Achievement
{
	public override string Ident => "building_11_university_count_09";
	public override string Name => "Ph.D. in pepperoni";
	public override string Description => "Purchase 400 Pizza Universities";
	public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 400;
	}
}
