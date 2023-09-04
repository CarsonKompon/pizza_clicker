using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementFreeLabour : Achievement
{
    public override string Ident => "pizzas_per_second_01";
    public override string Name => "Free labour";
    public override string Description => "Bake 1 pizza/sec";
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.PizzasPerSecond >= 1;
	}

}

