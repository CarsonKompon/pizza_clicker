using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeAchievements3 : Upgrade
{
	public override string Ident => "upgrade_achievements_03";
	public override string Name => "Pizza Cutter III";
	public override string Description => "You gain 1.5% more pizzas/sec for every achievement you have";
	public override double Cost => 90_000_000_000_000;
	public override string Icon => "ui/upgrades/pizza_cutter.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.AchievementResearch >= 50;
	}

	public override void OnPurchase( Player player )
	{
		player.AchievementMultiplier += 0.015d;
	}
}
