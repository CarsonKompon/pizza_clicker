using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingAchievementBonus : Blessing
{
	public override string Ident => "achievement_bonus";
	public override string Name => "Pays to be a winner";
	public override string Description => "Earn an additional +1% PpS for each achievement you have unlocked";
	public override double Cost => 100;
}
