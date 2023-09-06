using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSboxConsole1 : Upgrade
{
    public override string Ident => "upgrade_sbox_console_1";
    public override string Name => "Bronze S&box Console";
    public override string Description => "S&box Consoles are twice as effective";
    public override double Cost => double.Parse("710,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/sbox_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("sbox_console") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sbox_console", 2);
    }

}

