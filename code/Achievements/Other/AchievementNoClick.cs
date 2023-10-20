using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementNoClick : Achievement
{
    public override string Ident => "no_click";
    public override string Name => "No clicking";
    public override string Description => "Bake 1,000 pizzas in one lifetime without clicking once.";
    public override string Icon => "ui/upgrades/cursor.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalPizzasBaked >= 1_000 && player.TotalClicks == 0;
	}

}

