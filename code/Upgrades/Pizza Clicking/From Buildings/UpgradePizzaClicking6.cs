using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradePizzaClicker6 : Upgrade
{
	public override string Ident => "upgrade_pizza_clicker_6";
	public override string Name => "Oven Mitts";
	public override string Description => "Clicks bake one additional pizza for each building owned";
	public override double Cost => 100_000;
	public override string Icon => "ui/upgrades/oven_mitts.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetTotalBuildingResearch() >= 50;
	}
}
