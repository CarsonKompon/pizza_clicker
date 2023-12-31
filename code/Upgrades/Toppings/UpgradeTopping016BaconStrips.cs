using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping16BaconStrips : Upgrade
{
	public override string Ident => "upgrade_topping_016_bacon_strips";
	public override string Name => "Bacon Strips Topping";
	public override string Description => "Pizza production is increased by 5%";
	public override double Cost => 100_000_000_000;
	public override string Icon => "ui/upgrades/topping_bacon_strips.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 5_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.05d;
	}
}
