using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping30Salami : Upgrade
{
    public override string Ident => "upgrade_topping_030_salami";
    public override string Name => "Salami Toppings";
    public override string Description => "Pizza production is increased by 5%";
    public override double Cost => 50_000_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_salami.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 2_500_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.05d;
    }

}

