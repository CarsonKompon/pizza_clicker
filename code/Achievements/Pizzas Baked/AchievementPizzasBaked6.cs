using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked6 : Achievement
{
    public override string Ident => "pizzas_baked_06";
    public override string Name => "The billionth slice";
    public override string Description => "Bake 1 billion pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1_000_000_000;
	}

}

