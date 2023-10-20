using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount8 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_08";
	public override string Name => "Orange box of pizza";
	public override string Description => "Purchase 350 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 350;
	}
}
