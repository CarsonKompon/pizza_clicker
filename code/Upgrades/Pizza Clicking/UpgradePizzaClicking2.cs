using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker2 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_2";
    public override string Name => "Pizza Fingers II";
    public override string Description => "Clicks bake pizzas twice as efficiently";
    public override double Cost => 500;
    public override string Icon => "ui/pizzas/cheese_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalClicks >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.PizzasPerClick *= 2;
    }

}

