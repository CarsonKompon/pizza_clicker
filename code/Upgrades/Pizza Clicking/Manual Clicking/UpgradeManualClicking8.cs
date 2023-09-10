using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking8 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_08";
    public override string Name => "Pizza Pointer III";
    public override string Description => "Clicking gains +1% of your pizzas/sec";
    public override double Cost => 5_000_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pointer_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= 100_000_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}

