using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeThemePark7 : Upgrade
{
	public override string Ident => "upgrade_theme_park_7";
	public override string Name => "Silver Adventure World";
	public override string Description => "Pizza Theme Parks are twice as effective";
	public override double Cost => double.Parse( "165,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/adventure_world_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_theme_park" ) >= 200;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_theme_park", 2 );
	}
}
