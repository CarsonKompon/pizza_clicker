using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked5 : Achievement
{
    public override string Ident => "pizzas_baked_05";
    public override string Name => "Pizzapocalypse";
    public override string Description => "Bake 100 million pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 100_000_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalPizzasBaked / 100_000_000d;
	}
}
