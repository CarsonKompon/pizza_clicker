using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking9 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_09";
    public override string Name => "Pizza Pointer IV";
    public override string Description => "Clicking gains +1% of your pizzas/sec";
    public override double Cost => float.Parse("500,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pointer_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= 10_000_000_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}

