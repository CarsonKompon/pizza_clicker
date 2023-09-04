using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzasBaked7 : Achievement
{
    public override string Ident => "pizzas_baked_07";
    public override string Name => "Transcendental dough";
    public override string Description => "Bake 100 billion pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 100_000_000_000;
	}

}

