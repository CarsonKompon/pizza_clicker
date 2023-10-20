using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked8 : Achievement
{
    public override string Ident => "pizzas_baked_08";
    public override string Name => "Infinite dough";
    public override string Description => "Bake 1 trillion pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1_000_000_000_000;
	}

}

