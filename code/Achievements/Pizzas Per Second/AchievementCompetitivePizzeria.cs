using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementCompetitivePizzeria : Achievement
{
    public override string Ident => "competitive_pizzeria";
    public override string Name => "Competitive pizzeria";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 10;
	}

}

