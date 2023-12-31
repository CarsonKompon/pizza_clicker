using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInterdimensionalCount10 : Achievement
{
	public override string Ident => "building_13_interdimensional_count_10";
	public override string Name => "Infinite pizzas in infinite worlds";
	public override string Description => "Purchase 450 Interdimensional Pizzerias";
	public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 450;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) / 450d;
	}
}
