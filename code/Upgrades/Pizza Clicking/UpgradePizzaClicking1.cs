using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker1 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_1";
    public override string Name => "Pizza Fingers I";
    public override string Description => "Clicks bake pizzas twice as efficiently";
    public override double Cost => 100;
    public override string Icon => "ui/pizzas/cheese_pizza.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalClicks >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.PizzasPerClick *= 2;
    }

}

