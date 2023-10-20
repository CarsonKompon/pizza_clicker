using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaGPT8 : Upgrade
{
	public override string Ident => "upgrade_pizza_gpt_8";
	public override string Name => "Gold PizzaGPT-4";
	public override string Description => "PizzaGPTs are twice as effective";
	public override double Cost => double.Parse( "7,000,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_gpt_4_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 250;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_gpt", 2 );
	}
}
