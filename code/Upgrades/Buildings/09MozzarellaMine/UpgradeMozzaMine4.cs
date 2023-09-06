using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeMozzaMine4 : Upgrade
{
    public override string Ident => "upgrade_mozza_mine_4";
    public override string Name => "Prismatic Mozzarella Mine";
    public override string Description => "Mozzarella Mines are twice as effective";
    public override double Cost => 255_000_000_000_000;
    public override string Icon => "ui/upgrades/mozzarella_mine_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("mozzarella_mine") >= 50;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("mozzarella_mine", 2);
    }

}

