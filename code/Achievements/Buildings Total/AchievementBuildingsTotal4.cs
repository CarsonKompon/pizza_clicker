using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementBuildingsTotal4 : Achievement
{
    public override string Ident => "buildings_total_04";
    public override string Name => "Grand designer";
    public override string Description => "Own 2,500 buildings";
    public override string Icon => "ui/icons/house.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetTotalBuildingResearch() >= 2_500;
	}

}

