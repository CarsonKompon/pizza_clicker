using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker11 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_11";
	public override string Name => "Heat-Resistant Gloves";
	public override string Description => "Multiplies the gain from Oven Mitts by 20";
	public override double Cost => 10_000_000_000_000;
	public override string Icon => "ui/upgrades/heat_gloves.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.TotalBuildingResearch >= 800;
	}

	public override void OnPurchase( Player player )
	{
		player.MittenMultiplier *= 20;
	}
}
