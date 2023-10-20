using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAscension1 : Achievement
{
	public override string Ident => "ascension_01";
	public override string Name => "Rebirth";
	public override string Description => "Ascend at least once.";
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AscensionCount > 0;
	}
}
