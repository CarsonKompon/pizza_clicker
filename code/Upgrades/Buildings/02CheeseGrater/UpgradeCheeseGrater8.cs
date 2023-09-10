using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeCheeseGrater8 : Upgrade
{
    public override string Ident => "upgrade_cheese_grater_8";
    public override string Name => "Gold Cheese Shredder";
    public override string Description => "Cheese Graters are twice as effective";
    public override double Cost => 50_000_000_000_000_000;
    public override string Icon => "ui/upgrades/cheese_shredder_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("cheese_grater") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("cheese_grater", 2);
    }

}

