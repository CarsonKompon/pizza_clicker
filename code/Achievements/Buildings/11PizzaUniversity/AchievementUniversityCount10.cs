using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUniversityCount10 : Achievement
{
	public override string Ident => "building_11_university_count_10";
	public override string Name => "The alma mater";
	public override string Description => "Purchase 450 Pizza Universities";
	public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 450;
	}
}
