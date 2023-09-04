using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzasPerSecond3 : Achievement
{
    public override string Ident => "pizzas_per_second_03";
    public override string Name => "Competitive pizzeria";
    public override string Description => "Bake 100 pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 100;
	}

}

