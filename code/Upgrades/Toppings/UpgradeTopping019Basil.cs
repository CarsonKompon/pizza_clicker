using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping19Basil : Upgrade
{
    public override string Ident => "upgrade_topping_019_basil";
    public override string Name => "Basil Topping";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 1_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_basil.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 50_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

