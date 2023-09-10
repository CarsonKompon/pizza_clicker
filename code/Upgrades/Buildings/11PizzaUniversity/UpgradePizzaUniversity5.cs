using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaUniversity5 : Upgrade
{
    public override string Ident => "upgrade_university_5";
    public override string Name => "Pizza Research Institute";
    public override string Description => "Pizza Universities are twice as effective";
    public override double Cost => 5_000_000_000_000_000_000;
    public override string Icon => "ui/upgrades/research_institute.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_university") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_university", 2);
    }

}

