using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMozzaMineCount6 : Achievement
{
    public override string Ident => "building_09_mozza_mine_count_06";
    public override string Name => "Dig dug dough";
    public override string Description => "Purchase 250 Mozzarella Mines";
    public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("mozzarella_mine") >= 250;
	}

}
