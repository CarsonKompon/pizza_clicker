using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementInterdimensionalCount2 : Achievement
{
	public override string Ident => "building_13_interdimensional_count_02";
	public override string Name => "Slipstream supreme";
	public override string Description => "Purchase 50 Interdimensional Pizzerias";
	public override string Icon => "/ui/buildings/interdimensional_pizzeria.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "interdimensional_pizzeria" ) / 50d;
	}
}
