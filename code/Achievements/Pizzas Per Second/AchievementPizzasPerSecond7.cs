using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasPerSecond7 : Achievement
{
    public override string Ident => "pizzas_per_second_07";
    public override string Name => "Quantum crust";
    public override string Description => "Bake 1 million pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 1_000_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.PizzasPerSecond / 1_000_000d;
	}
}
