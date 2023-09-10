using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaUniversity1 : Upgrade
{
    public override string Ident => "upgrade_university_1";
    public override string Name => "Bronze University";
    public override string Description => "Pizza Universities are twice as effective";
    public override double Cost => 10_000_000_000_000;
    public override string Icon => "ui/upgrades/university_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_university") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_university", 2);
    }

}

