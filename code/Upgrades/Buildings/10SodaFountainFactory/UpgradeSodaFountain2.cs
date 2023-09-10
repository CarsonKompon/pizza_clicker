using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSodaFountain2 : Upgrade
{
    public override string Ident => "upgrade_soda_fountain_2";
    public override string Name => "Silver Soda Fountain Factory";
    public override string Description => "Soda Fountain Factories are twice as effective";
    public override double Cost => 3_750_000_000_000;
    public override string Icon => "ui/upgrades/soda_fountain_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("soda_fountain_factory") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("soda_fountain_factory", 2);
    }

}

