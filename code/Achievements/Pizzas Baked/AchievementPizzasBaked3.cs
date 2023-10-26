using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked3 : Achievement
{
    public override string Ident => "pizzas_baked_03";
    public override string Name => "Bake it till you make it";
    public override string Description => "Bake 100,000 pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 100_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalPizzasBaked / 100_000d;
	}
}
