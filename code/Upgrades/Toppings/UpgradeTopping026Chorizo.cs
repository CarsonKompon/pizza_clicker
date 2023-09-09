using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping26Chorizo: Upgrade
{
    public override string Ident => "upgrade_topping_026_chorizo";
    public override string Name => "Chorizo Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 1_000_000_000_000_000;
    public override string Icon => "ui/upgrades/topping_chorizo.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 50_000_000_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

