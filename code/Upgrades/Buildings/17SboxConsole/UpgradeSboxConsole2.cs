using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSboxConsole2 : Upgrade
{
    public override string Ident => "upgrade_sbox_console_2";
    public override string Name => "Silver S&box Console";
    public override string Description => "S&box Consoles are twice as effective";
    public override double Cost => double.Parse("3,550,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/sbox_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("sbox_console") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sbox_console", 2);
    }

}

