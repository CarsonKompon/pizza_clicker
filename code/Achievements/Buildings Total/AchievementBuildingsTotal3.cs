using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementBuildingsTotal3 : Achievement
{
    public override string Ident => "buildings_total_03";
    public override string Name => "Engineer";
    public override string Description => "Own 1,000 buildings";
    public override string Icon => "ui/icons/house.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetTotalBuildingCount() >= 1_000;
	}

}

