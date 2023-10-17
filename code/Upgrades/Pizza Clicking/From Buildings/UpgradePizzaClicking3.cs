using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker3 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_3";
	public override string Name => "Pizza Fingers III";
	public override string Description => "Clicks bake pizzas twice as efficiently";
	public override double Cost => 5_000;
	public override string Icon => "ui/upgrades/fingers_3.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetTotalBuildingResearch() >= 10;
	}

	public override void OnPurchase( Player player )
	{
		player.PizzasPerClick *= 2;
	}
}
