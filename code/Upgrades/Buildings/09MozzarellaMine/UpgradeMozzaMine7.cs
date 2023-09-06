using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeMozzaMine7 : Upgrade
{
    public override string Ident => "upgrade_mozza_mine_7";
    public override string Name => "Silver Cheese Quarry";
    public override string Description => "Mozzarella Mines are twice as effective";
    public override double Cost => double.Parse("2,550,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/cheese_quarry_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("mozzarella_mine") >= 200;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("mozzarella_mine", 2);
    }

}

