using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInterdimensionalCount8 : Achievement
{
	public override string Ident => "building_13_interdimensional_count_08";
	public override string Name => "Parallel pizzas";
	public override string Description => "Purchase 350 Interdimensional Pizzerias";
	public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) / 350d;
	}
}
