using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementFiftyNights : Achievement
{
    public override string Ident => "fifty_nights";
    public override string Name => "Fifty Nights at Frederick's";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("animatronic_arcade") >= 50;
	}

}

