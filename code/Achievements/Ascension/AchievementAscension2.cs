using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAscension2 : Achievement
{
	public override string Ident => "ascension_02";
	public override string Name => "Resurrection";
	public override string Description => "Ascend 5 times.";
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AscensionCount >= 5;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.AscensionCount / 5d;
	}
}
