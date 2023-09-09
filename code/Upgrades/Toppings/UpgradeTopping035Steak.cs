using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping35Steak : Upgrade
{
    public override string Ident => "upgrade_topping_035_steak";
    public override string Name => "Steak Topping";
    public override string Description => "Pizza production is increased by 3%";
    public override double Cost => 5_000_000_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_steak.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 250_000_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.03d;
    }

}

