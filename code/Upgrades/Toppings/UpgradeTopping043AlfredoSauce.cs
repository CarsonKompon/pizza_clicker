using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping43AlfredoSauce : Upgrade
{
	public override string Ident => "upgrade_topping_043_alfredo_sauce";
	public override string Name => "Alfredo Sauce Topping";
	public override string Description => "Pizza production is increased by 4%";
	public override double Cost => double.Parse( "50,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/topping_alfredo_sauce.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= double.Parse( "2,500,000,000,000,000,000,000" );
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.04d;
	}
}
