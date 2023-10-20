using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping29RedChilliFlakes : Upgrade
{
	public override string Ident => "upgrade_topping_029_red_chilli_flakes";
	public override string Name => "Red Chilli Flakes Topping";
	public override string Description => "Pizza production is increased by 2%";
	public override double Cost => 10_000_000_000_000_000;
	public override string Icon => "ui/upgrades/topping_red_chilli_flakes.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 500_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.02d;
	}
}
