using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzasBaked1 : Achievement
{
    public override string Ident => "pizzas_baked_01";
    public override string Name => "Just getting started";
    public override string Description => "Bake your first pizza";
    public override string Icon => "ui/pizzas/cheese_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1;
	}

}

