using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping37VeganCheese : Upgrade
{
    public override string Ident => "upgrade_topping_037_vegan_cheese";
    public override string Name => "Vegan Cheese Topping";
    public override string Description => "Pizza production is increased by 3%";
    public override double Cost => double.Parse("50,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/topping_vegan_cheese.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 2_500_000_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.03d;
    }

}

