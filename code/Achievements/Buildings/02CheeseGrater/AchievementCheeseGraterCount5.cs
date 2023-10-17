using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementCheeseGraterCount5 : Achievement
{
	public override string Ident => "building_02_cheese_grater_count_05";
	public override string Name => "Holesome";
	public override string Description => "Purchase 200 Cheese Graters";
	public override string Icon => "/ui/buildings/cheese_grater.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "cheese_grater" ) >= 200;
	}
}
