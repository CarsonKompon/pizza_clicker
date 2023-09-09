using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping5BellPeppers: Upgrade
{
    public override string Ident => "upgrade_topping_005_bell_peppers";
    public override string Name => "Bell Pepper Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 100_000_000;
    public override string Icon => "ui/upgrades/topping_bell_peppers.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 5_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

