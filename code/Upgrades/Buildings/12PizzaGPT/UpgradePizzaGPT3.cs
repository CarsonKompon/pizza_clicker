using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaGPT3 : Upgrade
{
	public override string Ident => "upgrade_pizza_gpt_3";
	public override string Name => "Gold PizzaGPT";
	public override string Description => "PizzaGPTs are twice as effective";
	public override double Cost => 7_000_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_gpt_gold.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_gpt", 2 );
	}
}
