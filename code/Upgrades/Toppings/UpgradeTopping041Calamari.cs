using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping41Calamari : Upgrade
{
	public override string Ident => "upgrade_topping_041_calamari";
	public override string Name => "Calamari Topping";
	public override string Description => "Pizza production is increased by 4%";
	public override double Cost => double.Parse( "5,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/topping_fresh_dill.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= double.Parse( "250,000,000,000,000,000,000" );
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.04d;
	}
}
