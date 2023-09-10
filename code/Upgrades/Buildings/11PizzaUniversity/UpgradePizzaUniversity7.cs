using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaUniversity7 : Upgrade
{
    public override string Ident => "upgrade_university_7";
    public override string Name => "Silver Research Institute";
    public override string Description => "Pizza Universities are twice as effective";
    public override double Cost => double.Parse("500,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/research_institute_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_university") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_university", 2);
    }

}

