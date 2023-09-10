using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeMozzaMine3 : Upgrade
{
    public override string Ident => "upgrade_mozza_mine_3";
    public override string Name => "Gold Mozzarella Mine";
    public override string Description => "Mozzarella Mines are twice as effective";
    public override double Cost => 2_550_000_000_000;
    public override string Icon => "ui/upgrades/mozzarella_mine_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("mozzarella_mine") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("mozzarella_mine", 2);
    }

}

