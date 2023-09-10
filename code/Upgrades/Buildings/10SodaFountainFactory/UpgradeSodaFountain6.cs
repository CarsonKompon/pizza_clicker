using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSodaFountain6 : Upgrade
{
    public override string Ident => "upgrade_soda_fountain_6";
    public override string Name => "Bronze Bottling Plant";
    public override string Description => "Soda Fountain Factories are twice as effective";
    public override double Cost => double.Parse("37,500,000,000,000,000,000");
    public override string Icon => "ui/upgrades/bottling_plant_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("soda_fountain_factory") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("soda_fountain_factory", 2);
    }

}

