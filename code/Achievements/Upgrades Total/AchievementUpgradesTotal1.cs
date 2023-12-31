using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementUpgradesTotal1 : Achievement
{
    public override string Ident => "upgrades_total_01";
    public override string Name => "Upgrader";
    public override string Description => "Purchase 20 upgrades";
    public override string Icon => "ui/icons/beaker.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalUpgradeCount >= 20;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalUpgradeCount / 20d;
	}
}
