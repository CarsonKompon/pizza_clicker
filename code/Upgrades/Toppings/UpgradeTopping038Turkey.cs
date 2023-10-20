using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping38Turkey : Upgrade
{
	public override string Ident => "upgrade_topping_038_turkey";
	public override string Name => "Turkey Toppings";
	public override string Description => "Pizza production is increased by 4%";
	public override double Cost => double.Parse( "100,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/topping_turkey.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 5_000_000_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.04d;
	}
}
