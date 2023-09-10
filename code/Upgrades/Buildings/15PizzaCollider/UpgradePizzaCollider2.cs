using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaCollider2 : Upgrade
{
    public override string Ident => "upgrade_pizza_collider_2";
    public override string Name => "Silver Quantum Pizza Collider";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => 1_300_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_collider_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("quantum_pizza_collider") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("quantum_pizza_collider", 2);
    }

}

