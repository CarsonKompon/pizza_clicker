using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzasBaked8 : Achievement
{
    public override string Ident => "pizzas_baked_08";
    public override string Name => "Infinite dough";
    public override string Description => "Bake 100 billion pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 100_000_000_000;
	}

}

