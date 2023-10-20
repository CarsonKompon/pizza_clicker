using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping4Sausage : Upgrade
{
	public override string Ident => "upgrade_topping_004_sausage";
	public override string Name => "Sausage Toppings";
	public override string Description => "Pizza production is increased by 2%";
	public override double Cost => 50_000_000;
	public override string Icon => "ui/upgrades/topping_sausage.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 2_500_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.02d;
	}
}
