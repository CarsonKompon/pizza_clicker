using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker3 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_3";
    public override string Name => "Pizza Fingers III";
    public override string Description => "Clicks bake pizzas twice as efficiently";
    public override double Cost => 10_000;
    public override string Icon => "ui/pizzas/cheese_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalClicks >= 1_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PizzasPerClick *= 2;
    }

}

