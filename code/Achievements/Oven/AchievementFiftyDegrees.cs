using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementFiftyDegrees : Achievement
{
    public override string Ident => "fifty_degrees";
    public override string Name => "Fifty Degrees of Crust";
    public override string Icon => "/ui/buildings/oven.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("oven") >= 50;
	}

}

