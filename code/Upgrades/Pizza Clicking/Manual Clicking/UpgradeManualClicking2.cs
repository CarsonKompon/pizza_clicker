using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeManualClicking2 : Upgrade
{
	public override string Ident => "upgrade_manual_clicking_02";
	public override string Name => "Pizza Cursor II";
	public override string Description => "Clicking gains +1% of your pizzas/sec";
	public override double Cost => 5_000_000;
	public override string Icon => "ui/upgrades/cursor_bronze.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.HandMadePizzas >= 100_000;
	}

	public override void OnPurchase( Player player )
	{
		player.PpSPercent += 1;
	}
}
