using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeTopping11BaconBits: Upgrade
{
    public override string Ident => "upgrade_topping_011_bacon_bits";
    public override string Name => "Bacon Bits Topping";
    public override string Description => "Pizza production is increased by 2%";
    public override double Cost => 500_000_000;
    public override string Icon => "ui/upgrades/topping_bacon_bits.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalPizzasBaked >= 25_000_000;
    }

    public override void OnPurchase(Player player)
    {
        player.TotalMultiplier += 0.02d;
    }

}

