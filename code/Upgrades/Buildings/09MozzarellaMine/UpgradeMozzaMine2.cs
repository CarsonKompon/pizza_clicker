using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeMozzaMine2 : Upgrade
{
    public override string Ident => "upgrade_mozza_mine_2";
    public override string Name => "Silver Mozzarella Mine";
    public override string Description => "Mozzarella Mines are twice as effective";
    public override double Cost => 255_000_000_000;
    public override string Icon => "ui/upgrades/mozzarella_mine_silver.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("mozzarella_mine") >= 5;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("mozzarella_mine", 2);
    }

}

