using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker5 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_5";
	public override string Name => "Pizza Fingers V";
	public override string Description => "Clicks bake pizzas twice as efficiently";
	public override double Cost => 25_000;
	public override string Icon => "ui/upgrades/fingers_5.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetTotalBuildingResearch() >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.PizzasPerClick *= 2;
	}
}
