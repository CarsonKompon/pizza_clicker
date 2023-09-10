using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMozzaMineCount7 : Achievement
{
    public override string Ident => "building_09_mozza_mine_count_07";
    public override string Name => "Deep cheeser";
    public override string Description => "Purchase 300 Mozzarella Mines";
    public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("mozzarella_mine") >= 300;
	}

}

