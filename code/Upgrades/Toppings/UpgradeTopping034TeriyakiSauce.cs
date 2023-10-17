using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeTopping34TeriyakiSauce : Upgrade
{
	public override string Ident => "upgrade_topping_034_teriyaki_sauce";
	public override string Name => "Teriyaki Sauce Topping";
	public override string Description => "Pizza production is increased by 3%";
	public override double Cost => 1_000_000_000_000_000_000;
	public override string Icon => "ui/upgrades/topping_teriyaki_sauce.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalPizzasBaked >= 50_000_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.TotalMultiplier += 0.03d;
	}
}
