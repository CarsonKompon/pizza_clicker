using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementMakingSomeDough : Achievement
{
    public override string Ident => "pizzas_baked_02";
    public override string Name => "Making some dough";
    public override string Description => "Bake 1,000 Pizzas";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.Pizzas >= 1000;
	}

}

