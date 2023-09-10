using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAnimatronicArcade5 : Upgrade
{
    public override string Ident => "upgrade_animatronic_arcade_5";
    public override string Name => "Animatronic Band Stage";
    public override string Description => "Animatronic Arcades are twice as effective";
    public override double Cost => 100_000_000_000_000;
    public override string Icon => "ui/upgrades/band_stage.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("animatronic_arcade") >= 100;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("animatronic_arcade", 2);
    }

}

