using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeGoldenPizza2 : Upgrade
{
    public override string Ident => "upgrade_gold_pizza_02";
    public override string Name => "Golden Pizza II";
    public override string Description => "Golden pizzas appear twice as often and last twice as long on screen.";
    public override double Cost => 77_777_777_777;
    public override string Icon => "ui/pizzas/gold_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalGoldClicks >= 27;
    }

    public override void OnPurchase(Player player)
    {
        player.GoldDuration *= 2;
        player.GoldMinTime /= 2;
        player.GoldMaxTime /= 2;
    }

}

