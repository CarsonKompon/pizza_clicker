using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker5 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_5";
    public override string Name => "Pizza Fingers V";
    public override string Description => "Clicks bake pizzas twice as efficiently";
    public override double Cost => 10_000_000;
    public override string Icon => "ui/pizzas/pepperoni_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalClicks >= 100_000;
    }

    public override void OnPurchase(Player player)
    {
        player.PizzasPerClick *= 2;
    }

}

