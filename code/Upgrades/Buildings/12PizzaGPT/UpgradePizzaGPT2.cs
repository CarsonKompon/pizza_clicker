using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaGPT2 : Upgrade
{
	public override string Ident => "upgrade_pizza_gpt_2";
	public override string Name => "Silver PizzaGPT";
	public override string Description => "PizzaGPTs are twice as effective";
	public override double Cost => 700_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_gpt_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 5;
	}

	public override void OnPurchase( Player player )
	{
		player.AddMultiplier( "pizza_gpt", 2 );
	}
}
