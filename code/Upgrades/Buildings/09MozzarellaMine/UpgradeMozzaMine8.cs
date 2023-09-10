using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeMozzaMine8 : Upgrade
{
    public override string Ident => "upgrade_mozza_mine_8";
    public override string Name => "Gold Cheese Quarry";
    public override string Description => "Mozzarella Mines are twice as effective";
    public override double Cost => double.Parse("2,550,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/cheese_quarry_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("mozzarella_mine") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("mozzarella_mine", 2);
    }

}

