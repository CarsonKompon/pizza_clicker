using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSboxConsoleCount1 : Achievement
{
    public override string Ident => "building_17_sbox_console_count_01";
    public override string Name => "Steam and sauce";
    public override string Description => "Purchase 1 S&box Console";
    public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("sbox_console") >= 1;
	}

}

