using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeDeliveryDriver7 : Upgrade
{
    public override string Ident => "upgrade_delivery_driver_7";
    public override string Name => "Silver Pizza Truck";
    public override string Description => "Delivery Drivers are twice as effective";
    public override double Cost => 6_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_truck_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("delivery_driver") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("delivery_driver", 2);
    }

}

