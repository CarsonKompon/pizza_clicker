using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping23BBQSauce: Upgrade
{
    public override string Ident => "upgrade_topping_023_bbq_sauce";
    public override string Name => "BBQ Sauce Topping";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 100_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_bbq_sauce.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 5_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

