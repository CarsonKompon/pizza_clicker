using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaCollider5 : Upgrade
{
    public override string Ident => "upgrade_pizza_collider_5";
    public override string Name => "Pizza Hadron Collider";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => double.Parse("130,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_hadron.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("quantum_pizza_collider") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("quantum_pizza_collider", 2);
    }

}

