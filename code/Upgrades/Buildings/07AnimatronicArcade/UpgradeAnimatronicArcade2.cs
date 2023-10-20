using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeAnimatronicArcade2 : Upgrade
{
	public override string Ident => "upgrade_animatronic_arcade_2";
	public override string Name => "Silver Animatronic Arcade";
	public override string Description => "Animatronic Arcades are twice as effective";
	public override double Cost => 1_000_000_000;
	public override string Icon => "ui/upgrades/animatronic_arcade_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "animatronic_arcade" ) >= 5;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "animatronic_arcade", 2 );
	}
}
