using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSboxConsoleCount7 : Achievement
{
    public override string Ident => "building_17_sbox_console_count_07";
    public override string Name => "Pain day";
    public override string Description => "Purchase 300 S&box Consoles";
    public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("sbox_console") >= 300;
	}

}

