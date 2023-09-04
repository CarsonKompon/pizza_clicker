using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCompetitivePizzeria : Achievement
{
    public override string Ident => "pizzas_per_second_02";
    public override string Name => "Competitive pizzeria";
    public override string Description => "Bake 10 pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 10;
	}

}

