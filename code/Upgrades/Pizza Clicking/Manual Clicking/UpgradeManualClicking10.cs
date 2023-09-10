using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking10 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_10";
    public override string Name => "Pizza Pointer V";
    public override string Description => "Clicking gains +1% of your pizzas/sec";
    public override double Cost => float.Parse("50,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pointer_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= double.Parse("1,000,000,000,000,000,000,000");
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}

