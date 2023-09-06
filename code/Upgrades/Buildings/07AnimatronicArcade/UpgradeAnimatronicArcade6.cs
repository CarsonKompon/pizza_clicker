using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAnimatronicArcade6 : Upgrade
{
    public override string Ident => "upgrade_animatronic_arcade_6";
    public override string Name => "Bronze Band Stage";
    public override string Description => "Animatronic Arcades are twice as effective";
    public override double Cost => 10_000_000_000_000_000;
    public override string Icon => "ui/upgrades/band_stage_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("animatronic_arcade") >= 150;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("animatronic_arcade", 2);
    }

}

