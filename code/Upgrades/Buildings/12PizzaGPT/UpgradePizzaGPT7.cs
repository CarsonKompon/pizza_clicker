using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaGPT7 : Upgrade
{
    public override string Ident => "upgrade_pizza_gpt_7";
    public override string Name => "Silver PizzaGPT-4";
    public override string Description => "PizzaGPTs are twice as effective";
    public override double Cost => double.Parse("7,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/pizza_gpt_4_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_gpt") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_gpt", 2);
    }

}

