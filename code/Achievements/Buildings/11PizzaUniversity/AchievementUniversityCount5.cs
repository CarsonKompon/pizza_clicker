using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUniversityCount5 : Achievement
{
	public override string Ident => "building_11_university_count_05";
	public override string Name => "Magna cum laude";
	public override string Description => "Purchase 200 Pizza Universities";
	public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 200;
	}
}
