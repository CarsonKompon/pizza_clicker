using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeDeliveryDriver8 : Upgrade
{
    public override string Ident => "upgrade_delivery_driver_8";
    public override string Name => "Gold Pizza Truck";
    public override string Description => "Delivery Drivers are twice as effective";
    public override double Cost => 6_000_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_truck_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("delivery_driver") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("delivery_driver", 2);
    }

}

