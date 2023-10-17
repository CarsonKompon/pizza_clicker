using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked9 : Achievement
{
    public override string Ident => "pizzas_baked_09";
    public override string Name => "Immortal dough";
    public override string Description => "Bake 100 trillion pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 100_000_000_000_000;
	}

}

