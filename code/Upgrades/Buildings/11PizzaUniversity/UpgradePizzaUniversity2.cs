using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaUniversity2 : Upgrade
{
    public override string Ident => "upgrade_university_2";
    public override string Name => "Silver University";
    public override string Description => "Pizza Universities are twice as effective";
    public override double Cost => 50_000_000_000_000;
    public override string Icon => "ui/upgrades/university_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("pizza_university") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_university", 2);
    }

}

