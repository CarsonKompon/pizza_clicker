using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeDeliveryDriver5 : Upgrade
{
    public override string Ident => "upgrade_delivery_driver_5";
    public override string Name => "Pizza Truck";
    public override string Description => "Delivery Drivers are twice as effective";
    public override double Cost => 60_000_000_000;
    public override string Icon => "ui/upgrades/pizza_truck.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("delivery_driver") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("delivery_driver", 2);
    }

}

