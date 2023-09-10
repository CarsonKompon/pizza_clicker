using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementBuildingsTotal1 : Achievement
{
    public override string Ident => "buildings_total_01";
    public override string Name => "Builder";
    public override string Description => "Own 100 buildings";
    public override string Icon => "ui/icons/house.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetTotalBuildingCount() >= 100;
	}

}

