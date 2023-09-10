using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAscensionAmount3 : Achievement
{
    public override string Ident => "ascension_amount_03";
    public override string Name => "Oblivion";
    public override string Description => "Ascend with 1 trillion pizzas baked.";
    public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return GameMenu.Instance.Ascending &&
            player.TotalPizzasBaked >= 1_000_000_000_000;
	}

}

