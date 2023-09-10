using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSodaFountain5 : Upgrade
{
    public override string Ident => "upgrade_soda_fountain_5";
    public override string Name => "Beverage Bottling Plant";
    public override string Description => "Soda Fountain Factories are twice as effective";
    public override double Cost => 375_000_000_000_000_000;
    public override string Icon => "ui/upgrades/bottling_plant.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("soda_fountain_factory") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("soda_fountain_factory", 2);
    }

}

