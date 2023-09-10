using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeCheeseGrater2 : Upgrade
{
    public override string Ident => "upgrade_cheese_grater_2";
    public override string Name => "Silver Cheese Grater";
    public override string Description => "Cheese Graters are twice as effective";
    public override double Cost => 5_000;
    public override string Icon => "ui/upgrades/cheese_grater_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("cheese_grater") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("cheese_grater", 2);
    }

}

