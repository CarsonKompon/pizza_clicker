using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaUniversity4 : Upgrade
{
	public override string Ident => "upgrade_university_4";
	public override string Name => "Prismatic University";
	public override string Description => "Pizza Universities are twice as effective";
	public override double Cost => 50_000_000_000_000_000;
	public override string Icon => "ui/upgrades/university_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_university", 2 );
	}
}
