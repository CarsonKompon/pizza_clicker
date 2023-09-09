using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping39SrirachaSauce : Upgrade
{
    public override string Ident => "upgrade_topping_039_sriracha_sauce";
    public override string Name => "Sriracha Sauce Toppings";
    public override string Description => "Pizza production is increased by 4%";
    public override double Cost => double.Parse("500,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/topping_sriracha_sauce.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= double.Parse("25,000,000,000,000,000,000");
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.04d;
    }

}

