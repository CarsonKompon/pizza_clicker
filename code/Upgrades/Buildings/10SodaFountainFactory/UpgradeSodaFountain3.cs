using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeSodaFountain3 : Upgrade
{
	public override string Ident => "upgrade_soda_fountain_3";
	public override string Name => "Gold Soda Fountain Factory";
	public override string Description => "Soda Fountain Factories are twice as effective";
	public override double Cost => 37_500_000_000_000;
	public override string Icon => "ui/upgrades/soda_fountain_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "soda_fountain_factory", 2 );
	}
}
