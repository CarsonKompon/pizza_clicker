using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInterdimensionalCount6 : Achievement
{
	public override string Ident => "building_13_interdimensional_count_06";
	public override string Name => "Wormhole in one";
	public override string Description => "Purchase 250 Interdimensional Pizzerias";
	public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 250;
	}
}
