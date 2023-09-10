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
    public override string Icon => "ui/upgrades/fingers_1.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetTotalBuildingResearch() >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.PizzasPerClick *= 2;
    }

}

