using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementSboxConsoleCount4 : Achievement
{
	public override string Ident => "building_17_sbox_console_count_04";
	public override string Name => "Sauce 2";
	public override string Description => "Purchase 150 S&box Consoles";
	public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 150;
	}
}
