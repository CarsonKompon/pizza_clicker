using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeMozzaMine6 : Upgrade
{
	public override string Ident => "upgrade_mozza_mine_6";
	public override string Name => "Bronze Cheese Quarry";
	public override string Description => "Mozzarella Mines are twice as effective";
	public override double Cost => 2_550_000_000_000_000_000;
	public override string Icon => "ui/upgrades/cheese_quarry_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "mozzarella_mine" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "mozzarella_mine", 2 );
	}
}
