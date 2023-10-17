using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePlanetPizza6 : Upgrade
{
	public override string Ident => "upgrade_planet_pizza_6";
	public override string Name => "Bronze Pizza Empire";
	public override string Description => "Planets of Pizzas are twice as effective";
	public override double Cost => double.Parse( "1,050,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/galactic_empire_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "planet_of_pizza" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "planet_of_pizza", 2 );
	}
}
