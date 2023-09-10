using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementGoldenPizzas2 : Achievement
{
    public override string Ident => "golden_pizzas_02";
    public override string Name => "Lucky pizza";
    public override string Description => "Click 7 golden pizzas.";
    public override string Icon => "ui/pizzas/gold_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalGoldClicks >= 7;
	}

}

