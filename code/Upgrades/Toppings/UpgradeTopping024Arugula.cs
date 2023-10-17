using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping24Arugula : Upgrade
{
	public override string Ident => "upgrade_topping_024_arugula";
	public override string Name => "Arugula Topping";
	public override string Description => "Pizza production is increased by 2%";
	public override double Cost => 500_000_000_000_000;
	public override string Icon => "ui/upgrades/topping_arugula.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 25_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.02d;
	}
}
