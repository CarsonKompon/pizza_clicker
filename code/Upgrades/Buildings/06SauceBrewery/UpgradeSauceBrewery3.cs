using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeSauceBrewery3 : Upgrade
{
	public override string Ident => "upgrade_sauce_brewery_3";
	public override string Name => "Gold Sauce Brewery";
	public override string Description => "Sauce Breweries are twice as effective";
	public override double Cost => 700_000_000;
	public override string Icon => "ui/upgrades/sauce_brewery_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sauce_brewery" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "sauce_brewery", 2 );
	}
}
