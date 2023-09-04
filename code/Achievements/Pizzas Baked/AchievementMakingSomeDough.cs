using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMakingSomeDough : Achievement
{
    public override string Ident => "making_some_dough";
    public override string Name => "Making some dough";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.Pizzas >= 1000;
	}

}

