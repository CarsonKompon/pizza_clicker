using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaGPT6 : Upgrade
{
    public override string Ident => "upgrade_pizza_gpt_6";
    public override string Name => "Bronze PizzaGPT-4";
    public override string Description => "PizzaGPTs are twice as effective";
    public override double Cost => double.Parse("7,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_gpt_4_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_gpt") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_gpt", 2);
    }

}

