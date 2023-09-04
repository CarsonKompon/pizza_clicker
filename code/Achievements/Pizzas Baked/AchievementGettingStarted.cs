using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementGettingStarted : Achievement
{
    public override string Ident => "getting_started";
    public override string Name => "Just getting started";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.Pizzas >= 1;
	}

}

