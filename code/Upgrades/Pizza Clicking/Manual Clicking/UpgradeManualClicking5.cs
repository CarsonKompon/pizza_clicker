using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking5 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_05";
    public override string Name => "Pizza Cursor V";
    public override string Description => "Clicking gains +1% of your pizzas/sec";
    public override double Cost => 5_000_000_000_000;
    public override string Icon => "ui/upgrades/cursor_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= 100_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}

