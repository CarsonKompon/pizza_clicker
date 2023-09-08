using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeGoldenPizza3 : Upgrade
{
    public override string Ident => "upgrade_gold_pizza_03";
    public override string Name => "Golden Pizza III";
    public override string Description => "The effects of golden pizzas last twice as long.";
    public override double Cost => 77_777_777_777_777;
    public override string Icon => "ui/pizzas/gold_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalGoldClicks >= 77;
    }

    public override void OnPurchase(Player player)
    {
        player.GoldMultiplier *= 2;
    }

}

