using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementGoldenPizzas4 : Achievement
{
	public override string Ident => "golden_pizzas_04";
	public override string Name => "Fortune";
	public override string Description => "Click 77 golden pizzas.";
	public override string Icon => "ui/pizzas/gold_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalGoldClicks >= 77;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalGoldClicks / 77d;
	}
}
