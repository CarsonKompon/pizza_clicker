using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker4 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_4";
	public override string Name => "Pizza Fingers IV";
	public override string Description => "Clicks bake pizzas twice as efficiently";
	public override double Cost => 10_000;
	public override string Icon => "ui/upgrades/fingers_4.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalBuildingResearch >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.PizzasPerClick *= 2;
	}
}
