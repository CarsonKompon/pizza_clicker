using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping8Pineapple: Upgrade
{
    public override string Ident => "upgrade_topping_008_pineapple";
    public override string Name => "Pineapple Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 100_000_000;
    public override string Icon => "ui/upgrades/topping_pineapple.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 5_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

