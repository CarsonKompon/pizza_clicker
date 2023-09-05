using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaClicker8 : Upgrade
{
    public override string Ident => "upgrade_pizza_clicker_8";
    public override string Name => "Silver Oven Mitts";
    public override string Description => "Multiplies the gain from Oven Mitts by 10";
    public override double Cost => 100_000_000;
    public override string Icon => "ui/upgrades/oven_mitts_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.TotalClicks >= 10_000;
    }

    public override void OnPurchase(Player player)
    {
        player.MittenMultiplier *= 10;
    }

}

