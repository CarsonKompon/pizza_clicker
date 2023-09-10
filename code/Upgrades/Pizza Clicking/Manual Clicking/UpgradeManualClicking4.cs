using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking4 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_04";
    public override string Name => "Pizza Cursor IV";
    public override string Description => "Clicking gains +1% of your pizzas/sec";
    public override double Cost => 50_000_000_000;
    public override string Icon => "ui/upgrades/cursor_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= 1_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}

