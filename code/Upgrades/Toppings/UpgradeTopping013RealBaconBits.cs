using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping13RealBaconBits : Upgrade
{
	public override string Ident => "upgrade_topping_013_real_bacon_bits";
	public override string Name => "Real Bacon Bits Topping";
	public override string Description => "Pizza production is increased by 2%";
	public override double Cost => 5_000_000_000;
	public override string Icon => "ui/upgrades/topping_bacon_bits_real.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 250_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.02d;
	}
}
