using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaCollider3 : Upgrade
{
    public override string Ident => "upgrade_pizza_collider_3";
    public override string Name => "Gold Quantum Pizza Collider";
    public override string Description => "Planets of Pizzas are twice as effective";
    public override double Cost => 13_000_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_collider_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("quantum_pizza_collider") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("quantum_pizza_collider", 2);
    }

}

