using Sandbox;

namespace PizzaClicker.Upgrades;

[Library]
public class UpgradeAchievements2 : Upgrade
{
	public override string Ident => "upgrade_achievements_02";
	public override string Name => "Pizza Cutter II";
	public override string Description => "You gain 1% more pizzas/sec for every achievement you have";
	public override double Cost => 9_000_000_000;
	public override string Icon => "ui/upgrades/pizza_cutter.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetAchievementResearch() >= 25;
	}

	public override void OnPurchase( Player player )
	{
		player.AchievementMultiplier += 0.01d;
	}
}
