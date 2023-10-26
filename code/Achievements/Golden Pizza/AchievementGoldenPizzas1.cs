using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementGoldenPizzas1 : Achievement
{
	public override string Ident => "golden_pizzas_01";
	public override string Name => "Golden pizza";
	public override string Description => "Click a golden pizza.";
	public override string Icon => "ui/pizzas/gold_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalGoldClicks >= 1;
	}
}
