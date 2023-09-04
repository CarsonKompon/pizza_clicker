using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementBusinessIsBooming : Achievement
{
    public override string Ident => "business_is_booming";
    public override string Name => "Business is booming!";
    public override string Icon => "/ui/buildings/pizza_chain.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_chain") >= 1;
	}

}

