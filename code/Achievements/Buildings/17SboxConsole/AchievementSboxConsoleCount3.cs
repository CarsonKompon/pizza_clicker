using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount3 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_03";
	public override string Name => "Valve of marinara";
	public override string Description => "Purchase 100 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 100;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) / 100d;
	}
}
