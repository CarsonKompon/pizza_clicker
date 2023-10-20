using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked4 : Achievement
{
    public override string Ident => "pizzas_baked_04";
    public override string Name => "Pizza party";
    public override string Description => "Bake 1 million pizzas in total";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1_000_000;
	}

}

