using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount2 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_02";
	public override string Name => "Half-Crust 3";
	public override string Description => "Purchase 50 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) / 50d;
	}
}
