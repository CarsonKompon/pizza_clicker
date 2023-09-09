using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMozzaMineCount11 : Achievement
{
    public override string Ident => "building_09_mozza_mine_count_11";
    public override string Name => "Abyss of abundance";
    public override string Description => "Purchase 500 Mozzarella Mines";
    public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("mozzarella_mine") >= 500;
	}

}

