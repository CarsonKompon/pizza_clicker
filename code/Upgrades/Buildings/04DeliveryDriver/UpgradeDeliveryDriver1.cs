using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeDeliveryDriver1 : Upgrade
{
    public override string Ident => "upgrade_delivery_driver_1";
    public override string Name => "Bronze Delivery Driver";
    public override string Description => "Delivery Drivers are twice as effective";
    public override double Cost => 120_000;
    public override string Icon => "ui/upgrades/delivery_driver_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("delivery_driver") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("delivery_driver", 2);
    }

}

