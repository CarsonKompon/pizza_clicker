using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementPizzasPerSecond8 : Achievement
{
    public override string Ident => "pizzas_per_second_08";
    public override string Name => "Cosmic pizzeria";
    public override string Description => "Bake 10 million pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 10_000_000;
	}

}

