using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeSodaFountain1 : Upgrade
{
    public override string Ident => "upgrade_soda_fountain_1";
    public override string Name => "Bronze Soda Fountain Factory";
    public override string Description => "Soda Fountain Factories are twice as effective";
    public override double Cost => 750_000_000_000;
    public override string Icon => "ui/upgrades/soda_fountain_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("soda_fountain_factory") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("soda_fountain_factory", 2);
    }

}

