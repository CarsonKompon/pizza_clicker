using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping15GroundBeef: Upgrade
{
    public override string Ident => "upgrade_topping_015_ground_beef";
    public override string Name => "Ground Beef Toppings";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 50_000_000_000;
    public override string Icon => "ui/upgrades/topping_ground_beef.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 2_500_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

