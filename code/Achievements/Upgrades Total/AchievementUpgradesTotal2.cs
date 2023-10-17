using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUpgradesTotal2 : Achievement
{
    public override string Ident => "upgrades_total_02";
    public override string Name => "Enhancer";
    public override string Description => "Purchase 50 upgrades";
    public override string Icon => "ui/icons/beaker.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetTotalUpgradeCount() >= 50;
	}

}

