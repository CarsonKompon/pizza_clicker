using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping40FreshDill : Upgrade
{
	public override string Ident => "upgrade_topping_040_fresh_dill";
	public override string Name => "Fresh Dill Topping";
	public override string Description => "Pizza production is increased by 4%";
	public override double Cost => double.Parse( "1,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/topping_fresh_dill.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= double.Parse( "50,000,000,000,000,000,000" );
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.04d;
	}
}
