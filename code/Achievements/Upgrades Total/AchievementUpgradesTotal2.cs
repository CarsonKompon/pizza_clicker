using Sandbox;

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
        return player.TotalUpgradeCount >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalUpgradeCount / 50d;
	}
}
