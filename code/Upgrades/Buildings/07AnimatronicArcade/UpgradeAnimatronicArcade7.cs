using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeAnimatronicArcade7 : Upgrade
{
	public override string Ident => "upgrade_animatronic_arcade_7";
	public override string Name => "Silver Band Stage";
	public override string Description => "Animatronic Arcades are twice as effective";
	public override double Cost => 10_000_000_000_000_000_000;
	public override string Icon => "ui/upgrades/band_stage_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "animatronic_arcade" ) >= 200;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "animatronic_arcade", 2 );
	}
}
