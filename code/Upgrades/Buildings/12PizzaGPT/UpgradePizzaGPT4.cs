using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaGPT4 : Upgrade
{
    public override string Ident => "upgrade_pizza_gpt_4";
    public override string Name => "Prismatic PizzaGPT";
    public override string Description => "PizzaGPTs are twice as effective";
    public override double Cost => 700_000_000_000_000_000;
    public override string Icon => "ui/upgrades/pizza_gpt_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_gpt") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_gpt", 2);
    }

}

