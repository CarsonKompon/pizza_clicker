using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker2 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_2";
	public override string Name => "Pizza Fingers II";
	public override string Description => "Clicks bake pizzas twice as efficiently";
	public override double Cost => 500;
	public override string Icon => "ui/upgrades/fingers_2.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalBuildingResearch >= 5;
	}

	public override void OnPurchase( Player player )
	{
		player.PizzasPerClick *= 2;
	}
}
