using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeAchievements4 : Upgrade
{
	public override string Ident => "upgrade_achievements_04";
	public override string Name => "Pizza Cutter IV";
	public override string Description => "You gain 1.5% more pizzas/sec for every achievement you have";
	public override double Cost => 90_000_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_cutter.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AchievementResearch >= 75;
	}

	public override void OnPurchase( Player player )
	{
		player.AchievementMultiplier += 0.015d;
	}
}
