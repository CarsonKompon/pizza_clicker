using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping20Meatballs : Upgrade
{
    public override string Ident => "upgrade_topping_020_meatballs";
    public override string Name => "Meatball Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 5_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_meatballs.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 250_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

