using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAscension3 : Achievement
{
	public override string Ident => "ascension_03";
	public override string Name => "Reincarnation";
	public override string Description => "Ascend 10 times.";
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AscensionCount >= 10;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.AscensionCount / 10d;
	}
}
