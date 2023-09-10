using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSboxConsole4 : Upgrade
{
    public override string Ident => "upgrade_sbox_console_4";
    public override string Name => "Prismatic S&box Console";
    public override string Description => "S&box Consoles are twice as effective";
    public override double Cost => double.Parse("3,550,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/sbox_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("sbox_console") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sbox_console", 2);
    }

}

