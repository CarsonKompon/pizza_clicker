using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMozzaMineCount5 : Achievement
{
    public override string Ident => "building_09_mozza_mine_count_05";
    public override string Name => "Gouda grotto";
    public override string Description => "Purchase 200 Mozzarella Mines";
    public override string Icon => "/ui/buildings/mozzarella_mine.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("mozzarella_mine") >= 200;
	}

}

