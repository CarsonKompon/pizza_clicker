using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeSodaFountain4 : Upgrade
{
	public override string Ident => "upgrade_soda_fountain_4";
	public override string Name => "Prismatic Soda Fountain Factory";
	public override string Description => "Soda Fountain Factories are twice as effective";
	public override double Cost => 37_500_000_000_000_000;
	public override string Icon => "ui/upgrades/soda_fountain_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "soda_fountain_factory", 2 );
	}
}
