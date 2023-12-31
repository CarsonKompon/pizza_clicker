using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasPerSecond10 : Achievement
{
    public override string Ident => "pizzas_per_second_10";
    public override string Name => "Beyond space and thyme";
    public override string Description => "Bake 1 billion pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 1_000_000_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.PizzasPerSecond / 1_000_000_000d;
	}
}
