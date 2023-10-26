using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked10 : Achievement
{
    public override string Ident => "pizzas_baked_10";
    public override string Name => "To go beyond dough...";
    public override string Description => "Bake 1 quadrillion pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1_000_000_000_000_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalPizzasBaked / 1_000_000_000_000_000d;
	}
}
