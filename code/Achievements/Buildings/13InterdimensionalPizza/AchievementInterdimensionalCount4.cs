using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInterdimensionalCount4 : Achievement
{
	public override string Ident => "building_13_interdimensional_count_04";
	public override string Name => "String cheese theory";
	public override string Description => "Purchase 150 Interdimensional Pizzerias";
	public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 150;
	}
}
