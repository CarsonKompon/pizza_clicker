using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementHellsKitchen : Achievement
{
    public override string Ident => "hells_kitchen";
    public override string Name => "Hell's Kitchen";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 250;
	}

}

