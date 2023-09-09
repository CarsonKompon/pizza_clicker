using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping12Jalapeno: Upgrade
{
    public override string Ident => "upgrade_topping_012_jalapeno";
    public override string Name => "Jalapeño Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 500_000_000;
    public override string Icon => "ui/upgrades/topping_jalapeno.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 25_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

