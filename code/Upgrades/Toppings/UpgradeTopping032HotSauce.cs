using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping32HotSauce : Upgrade
{
	public override string Ident => "upgrade_topping_032_hot_sauce";
	public override string Name => "Hot Sauce Topping";
	public override string Description => "Pizza production is increased by 3%";
	public override double Cost => 100_000_000_000_000_000;
	public override string Icon => "ui/upgrades/topping_hot_sauce.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 5_000_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.03d;
	}
}
