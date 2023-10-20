using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping7Onions : Upgrade
{
	public override string Ident => "upgrade_topping_007_onions";
	public override string Name => "Red Onion Toppings";
	public override string Description => "Pizza production is increased by 2%";
	public override double Cost => 100_000_000;
	public override string Icon => "ui/upgrades/topping_red_onion.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 5_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.02d;
	}
}
