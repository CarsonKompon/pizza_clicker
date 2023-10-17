using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked2 : Achievement
{
    public override string Ident => "pizzas_baked_02";
    public override string Name => "Making some dough";
    public override string Description => "Bake 1,000 pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1000;
	}

}

