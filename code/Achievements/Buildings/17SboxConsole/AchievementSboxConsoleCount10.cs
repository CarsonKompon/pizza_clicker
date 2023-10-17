using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount10 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_10";
	public override string Name => "Developer preview";
	public override string Description => "Purchase 450 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 450;
	}
}
