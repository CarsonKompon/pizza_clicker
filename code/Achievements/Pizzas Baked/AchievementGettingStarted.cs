using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementGettingStarted : Achievement
{
    public override string Ident => "pizzas_baked_01";
    public override string Name => "Just getting started";
    public override string Description => "Bake 1 Pizza";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.Pizzas >= 1;
	}

}

