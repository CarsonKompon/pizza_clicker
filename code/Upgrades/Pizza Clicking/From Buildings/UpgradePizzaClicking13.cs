using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker13 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_13";
	public override string Name => "Silver Heat-Resistant Gloves";
	public override string Description => "Multiplies the gain from Oven Mitts by 20";
	public override double Cost => 10_000_000_000_000_000_000;
	public override string Icon => "ui/upgrades/heat_gloves_silver.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetTotalBuildingResearch() >= 1250;
	}

	public override void OnPurchase( Player player )
	{
		player.MittenMultiplier *= 20;
	}
}
