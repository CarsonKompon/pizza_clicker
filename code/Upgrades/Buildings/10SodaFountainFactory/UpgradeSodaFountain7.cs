using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeSodaFountain7 : Upgrade
{
	public override string Ident => "upgrade_soda_fountain_7";
	public override string Name => "Silver Bottling Plant";
	public override string Description => "Soda Fountain Factories are twice as effective";
	public override double Cost => double.Parse( "37,500,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/bottling_plant_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "soda_fountain_factory" ) >= 200;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "soda_fountain_factory", 2 );
	}
}
