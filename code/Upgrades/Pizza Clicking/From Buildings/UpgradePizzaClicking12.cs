using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker12 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_12";
	public override string Name => "Bronze Heat-Resistant Gloves";
	public override string Description => "Multiplies the gain from Oven Mitts by 20";
	public override double Cost => 10_000_000_000_000_000;
	public override string Icon => "ui/upgrades/heat_gloves_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalBuildingResearch >= 1000;
	}

	public override void OnPurchase( Player player )
	{
		player.MittenMultiplier *= 20;
	}
}
