using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementGoldenPizzas3 : Achievement
{
    public override string Ident => "golden_pizzas_03";
    public override string Name => "Stroke of luck";
    public override string Description => "Click 27 golden pizzas.";
    public override string Icon => "ui/pizzas/gold_pizza.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalGoldClicks >= 27;
	}

}

