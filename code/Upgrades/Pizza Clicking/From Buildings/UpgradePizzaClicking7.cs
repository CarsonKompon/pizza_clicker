using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker7 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_7";
	public override string Name => "Bronze Oven Mitts";
	public override string Description => "Multiplies the gain from Oven Mitts by 5";
	public override double Cost => 10_000_000;
	public override string Icon => "ui/upgrades/oven_mitts_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetTotalBuildingResearch() >= 100;
	}

	public override void OnPurchase( Player player )
	{
		player.MittenMultiplier *= 5;
	}
}
