using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount9 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_09";
	public override string Name => "Cake is a lie, but pizza is real";
	public override string Description => "Purchase 400 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) / 400d;
	}
}
