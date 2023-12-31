using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaGPT9 : Upgrade
{
	public override string Ident => "upgrade_pizza_gpt_9";
	public override string Name => "Prismatic PizzaGPT-4";
	public override string Description => "PizzaGPTs are twice as effective";
	public override double Cost => double.Parse( "7,000,000,000,000,000,000,000,000,000,000" );
	public override string Icon => "ui/upgrades/pizza_gpt_4_rainbow.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 300;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_gpt", 2 );
	}
}
