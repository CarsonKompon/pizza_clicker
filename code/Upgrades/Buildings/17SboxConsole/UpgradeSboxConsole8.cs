using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSboxConsole8 : Upgrade
{
    public override string Ident => "upgrade_sbox_console_8";
    public override string Name => "Gold S&box Dev Tools";
    public override string Description => "S&box Consoles are twice as effective";
    public override double Cost => double.Parse("35,500,000,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/sbox_dev_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("sbox_console") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("sbox_console", 2);
    }

}

