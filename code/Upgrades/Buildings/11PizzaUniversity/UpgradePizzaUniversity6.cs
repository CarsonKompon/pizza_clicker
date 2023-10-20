using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaUniversity6 : Upgrade
{
	public override string Ident => "upgrade_university_6";
	public override string Name => "Bronze Research Institute";
	public override string Description => "Pizza Universities are twice as effective";
	public override double Cost => double.Parse( "500,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/research_institute_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_university" ) >= 150;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_university", 2 );
	}
}
