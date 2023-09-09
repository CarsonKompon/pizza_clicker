using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping33Pastrami : Upgrade
{
    public override string Ident => "upgrade_topping_033_pastrami";
    public override string Name => "Pastrami Topping";
    public override string Description => "Pizza production is increased by 3%";
    public override double Cost => 500_000_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_pastrami.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 25_000_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.03d;
    }

}

