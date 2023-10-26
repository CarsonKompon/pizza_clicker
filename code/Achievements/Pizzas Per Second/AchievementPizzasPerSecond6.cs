using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasPerSecond6 : Achievement
{
    public override string Ident => "pizzas_per_second_06";
    public override string Name => "Lightning dough";
    public override string Description => "Bake 100,000 pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 100_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.PizzasPerSecond / 100_000d;
	}
}
