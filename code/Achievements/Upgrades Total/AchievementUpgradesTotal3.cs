using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUpgradesTotal3 : Achievement
{
    public override string Ident => "upgrades_total_03";
    public override string Name => "Augmenter";
    public override string Description => "Purchase 100 upgrades";
    public override string Icon => "ui/icons/beaker.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalUpgradeCount >= 100;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalUpgradeCount / 100d;
	}
}
