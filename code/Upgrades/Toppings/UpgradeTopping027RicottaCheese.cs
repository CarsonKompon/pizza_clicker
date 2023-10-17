using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping27RicottaCheese : Upgrade
{
	public override string Ident => "upgrade_topping_027_ricotta_cheese";
	public override string Name => "Ricotta Cheese Topping";
	public override string Description => "Pizza production is increased by 2%";
	public override double Cost => 1_000_000_000_000_000;
	public override string Icon => "ui/upgrades/topping_ricotta_cheese.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 50_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.02d;
	}
}
