using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSodaFountain9 : Upgrade
{
    public override string Ident => "upgrade_soda_fountain_9";
    public override string Name => "Prismatic Bottling Plant";
    public override string Description => "Soda Fountain Factories are twice as effective";
    public override double Cost => double.Parse("37,500,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/bottling_plant_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("soda_fountain_factory") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("soda_fountain_factory", 2);
    }

}

