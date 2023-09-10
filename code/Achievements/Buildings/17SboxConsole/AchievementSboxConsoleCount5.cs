using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementSboxConsoleCount5 : Achievement
{
    public override string Ident => "building_17_sbox_console_count_05";
    public override string Name => "Sauce code access";
    public override string Description => "Purchase 200 S&box Consoles";
    public override string Icon => "/ui/buildings/sbox_console.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("sbox_console") >= 200;
	}

}

