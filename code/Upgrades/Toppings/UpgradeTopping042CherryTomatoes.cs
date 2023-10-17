using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping42CherryTomatoes : Upgrade
{
	public override string Ident => "upgrade_topping_042_cherry_tomatoes";
	public override string Name => "Cherry Tomato Toppings";
	public override string Description => "Pizza production is increased by 4%";
	public override double Cost => double.Parse( "10,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/topping_cherry_tomatoes.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= double.Parse( "500,000,000,000,000,000,000" );
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.04d;
	}
}
