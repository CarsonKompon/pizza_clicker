using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradePizzaUniversity3 : Upgrade
{
    public override string Ident => "upgrade_university_3";
    public override string Name => "Gold University";
    public override string Description => "Pizza Universities are twice as effective";
    public override double Cost => 500_000_000_000_000;
    public override string Icon => "ui/upgrades/university_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("pizza_university") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("pizza_university", 2);
    }

}

