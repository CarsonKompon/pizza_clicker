using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeSboxConsole5 : Upgrade
{
	public override string Ident => "upgrade_sbox_console_5";
	public override string Name => "S&box Dev Tools";
	public override string Description => "S&box Consoles are twice as effective";
	public override double Cost => double.Parse( "355,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/sbox_dev.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "sbox_console" ) >= 100;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "sbox_console", 2 );
	}
}
