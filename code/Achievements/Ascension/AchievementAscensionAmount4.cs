using Sandbox;
using System;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAscensionAmount4 : Achievement
{
	public override string Ident => "ascension_amount_04";
	public override string Name => "Nihilism";
	public override string Description => "Ascend with 1 quadrillion pizzas baked.";
	public override string Icon => "ui/icons/trophy.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return GameMenu.Instance.Ascending &&
			player.TotalPizzasBaked >= 1_000_000_000_000_000;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return Math.Min( player.TotalPizzasBaked / 1_000_000_000_000_000d, 1 );
	}
}
