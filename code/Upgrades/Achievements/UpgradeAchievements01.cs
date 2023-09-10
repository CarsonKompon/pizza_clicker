using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAchievements1 : Upgrade
{
    public override string Ident => "upgrade_achievements_01";
    public override string Name => "Pizza Cutter I";
    public override string Description => "You gain 1% more pizzas/sec for every achievement you have";
    public override double Cost => 9_000_000;
    public override string Icon => "ui/upgrades/pizza_cutter.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetAchievementResearch() >= 10;
    }

    public override void OnPurchase(Player player)
    {
        player.AchievementMultiplier += 0.01d;
    }

}

