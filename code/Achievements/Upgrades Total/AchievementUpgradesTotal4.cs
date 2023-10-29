using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUpgradesTotal4 : Achievement
{
    public override string Ident => "upgrades_total_04";
    public override string Name => "Making good progress";
    public override string Description => "Purchase 200 upgrades";
    public override string Icon => "ui/icons/beaker.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalUpgradeCount >= 200;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalUpgradeCount / 200d;
	}
}
