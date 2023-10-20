using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInterdimensionalCount9 : Achievement
{
	public override string Ident => "building_13_interdimensional_count_09";
	public override string Name => "Tesseract toppings";
	public override string Description => "Purchase 400 Interdimensional Pizzerias";
	public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 400;
	}
}
