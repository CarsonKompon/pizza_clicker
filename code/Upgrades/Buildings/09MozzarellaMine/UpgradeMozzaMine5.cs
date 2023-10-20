using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeMozzaMine5 : Upgrade
{
	public override string Ident => "upgrade_mozza_mine_5";
	public override string Name => "Cheese Quarry";
	public override string Description => "Mozzarella Mines are twice as effective";
	public override double Cost => 25_500_000_000_000_000;
	public override string Icon => "ui/upgrades/cheese_quarry.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) >= 100;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "mozzarella_mine", 2 );
	}
}
