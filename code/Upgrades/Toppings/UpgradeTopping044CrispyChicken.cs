using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping44CrispyChicken : Upgrade
{
	public override string Ident => "upgrade_topping_044_crispy_chicken";
	public override string Name => "Crispy Chicken Toppings";
	public override string Description => "Pizza production is increased by 4%";
	public override double Cost => double.Parse( "100,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/topping_crispy_chicken.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= double.Parse( "5,000,000,000,000,000,000,000" );
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.04d;
	}
}
