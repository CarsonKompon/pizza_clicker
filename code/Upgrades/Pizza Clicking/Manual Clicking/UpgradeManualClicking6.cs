using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeManualClicking6 : Upgrade
{
	public override string Ident => "upgrade_manual_clicking_06";
	public override string Name => "Pizza Pointer I";
	public override string Description => "Clicking gains +1% of your pizzas/sec";
	public override double Cost => 500_000_000_000_000;
	public override string Icon => "ui/upgrades/pointer.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.HandMadePizzas >= 10_000_000_000_000;
	}

	public override void OnPurchase( Player player )
	{
		player.PpSPercent += 1;
	}
}
