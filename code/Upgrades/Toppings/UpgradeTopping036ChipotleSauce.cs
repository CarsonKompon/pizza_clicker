using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping36ChipotleSauce : Upgrade
{
	public override string Ident => "upgrade_topping_036_chipotle_sauce";
	public override string Name => "Chipotle Sauce Topping";
	public override string Description => "Pizza production is increased by 3%";
	public override double Cost => 10_000_000_000_000_000_000;
	public override string Icon => "ui/upgrades/topping_chipotle_sauce.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 500_000_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.03d;
	}
}
