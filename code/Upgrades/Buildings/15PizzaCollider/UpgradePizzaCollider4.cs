using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaCollider4 : Upgrade
{
    public override string Ident => "upgrade_pizza_collider_4";
    public override string Name => "Prismatic Quantum Pizza Collider";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => double.Parse("1,300,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_collider_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("quantum_pizza_collider") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("quantum_pizza_collider", 2);
    }

}

