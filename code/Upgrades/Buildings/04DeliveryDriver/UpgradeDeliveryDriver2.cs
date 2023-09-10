using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeDeliveryMan2 : Upgrade
{
    public override string Ident => "upgrade_delivery_driver_2";
    public override string Name => "Silver Delivery Driver";
    public override string Description => "Delivery Driver are twice as effective";
    public override double Cost => 600_000;
    public override string Icon => "ui/upgrades/delivery_driver_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("delivery_driver") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("delivery_driver", 2);
    }

}

