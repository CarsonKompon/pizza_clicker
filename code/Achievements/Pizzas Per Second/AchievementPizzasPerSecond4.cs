using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasPerSecond4 : Achievement
{
    public override string Ident => "pizzas_per_second_04";
    public override string Name => "Thunder crust";
    public override string Description => "Bake 1,000 pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 1_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.PizzasPerSecond / 1_000d;
	}
}
