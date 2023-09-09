using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping31CarmelizedOnions : Upgrade
{
    public override string Ident => "upgrade_topping_031_carmelized_onions";
    public override string Name => "Carmelized Onions Topping";
    public override string Description => "Pizza production is increased by 5%";
    public override double Cost => 50_000_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_carmelized_onions.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 2_500_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.05d;
    }

}

