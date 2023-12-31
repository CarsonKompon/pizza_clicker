using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementGoldenPizzas5 : Achievement
{
    public override string Ident => "golden_pizzas_05";
    public override string Name => "Leprechaun";
    public override string Description => "Click 777 golden pizzas.";
    public override string Icon => "ui/pizzas/gold_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalGoldClicks >= 777;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalGoldClicks / 777d;
	}
}
