using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeGoldenPizza1 : Upgrade
{
    public override string Ident => "upgrade_gold_pizza_01";
    public override string Name => "Golden Pizza I";
    public override string Description => "Golden pizzas appear twice as often and last twice as long on screen.";
    public override double Cost => 777_777_777;
    public override string Icon => "ui/pizzas/gold_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalGoldClicks >= 7;
    }

    public override void OnPurchase(Player player)
    {
        player.GoldDuration *= 2;
        player.GoldMinTime /= 2;
        player.GoldMaxTime /= 2;
    }

}

