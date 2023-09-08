using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeManualClicking1 : Upgrade
{
    public override string Ident => "upgrade_manual_clicking_01";
    public override string Name => "Pizza Cursor I";
    public override string Description => "Clicking gains +1% of your PpS";
    public override double Cost => 50_000;
    public override string Icon => "ui/upgrades/cursor.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HandMadePizzas >= 1_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PpSPercent += 1;
    }

}
