using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount11 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_11";
	public override string Name => "sv_cheats 1";
	public override string Description => "Purchase 500 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 500;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) / 500d;
	}
}
