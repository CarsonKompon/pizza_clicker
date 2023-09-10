using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking3 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_03";
    public override string Name => "Pizza Cursor III";
    public override string Description => "Clicking gains +1% of your pizzas/sec";
    public override double Cost => 500_000_000;
    public override string Icon => "ui/upgrades/cursor_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= 10_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}

