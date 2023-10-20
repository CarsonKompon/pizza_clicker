using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasPerSecond9 : Achievement
{
    public override string Ident => "pizzas_per_second_09";
    public override string Name => "Universal pie";
    public override string Description => "Bake 100 million pizzas/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 100_000_000;
	}

}

