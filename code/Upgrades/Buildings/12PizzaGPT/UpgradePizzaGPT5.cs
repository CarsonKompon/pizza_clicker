using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaGPT5 : Upgrade
{
    public override string Ident => "upgrade_pizza_gpt_5";
    public override string Name => "PizzaGPT-4";
    public override string Description => "PizzaGPTs are twice as effective";
    public override double Cost => double.Parse("70,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_gpt_4.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_gpt") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_gpt", 2);
    }

}

