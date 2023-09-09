using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping3Mushrooms : Upgrade
{
    public override string Ident => "upgrade_topping_003_mushrooms";
    public override string Name => "Mushroom Toppings";
    public override string Description => "Pizza production is increased by 1%";
    public override double Cost => 10_000_000;
    public override string Icon => "ui/upgrades/topping_mushrooms.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 500_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.01d;
    }

}

