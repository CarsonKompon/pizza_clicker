using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeSauceBrewery6 : Upgrade
{
	public override string Ident => "upgrade_sauce_brewery_6";
	public override string Name => "Bronze Taste Testing Factory";
	public override string Description => "Sauce Breweries are twice as effective";
	public override double Cost => 700_000_000_000_000;
	public override string Icon => "ui/upgrades/taste_factory_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "sauce_brewery", 2 );
	}
}
