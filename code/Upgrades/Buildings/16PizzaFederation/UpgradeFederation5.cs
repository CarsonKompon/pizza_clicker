using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeFederation5 : Upgrade
{
	public override string Ident => "upgrade_pizza_federation_5";
	public override string Name => "United Federation of Pizzas";
	public override string Description => "Pizza Federations are twice as effective";
	public override double Cost => double.Parse( "1,550,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/united_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 100;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_federation", 2 );
	}
}
