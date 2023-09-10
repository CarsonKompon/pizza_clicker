using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaCollider7 : Upgrade
{
    public override string Ident => "upgrade_pizza_collider_7";
    public override string Name => "Silver Hadron Collider";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => double.Parse("13,000,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_hadron_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("quantum_pizza_collider") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("quantum_pizza_collider", 2);
    }

}

