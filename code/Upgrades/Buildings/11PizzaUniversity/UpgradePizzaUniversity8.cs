using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaUniversity8 : Upgrade
{
    public override string Ident => "upgrade_university_8";
    public override string Name => "Gold Research Institute";
    public override string Description => "Pizza Universities are twice as effective";
    public override double Cost => double.Parse("500,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/research_institute_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_university") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_university", 2);
    }

}

