using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAnimatronicArcade9 : Upgrade
{
    public override string Ident => "upgrade_animatronic_arcade_9";
    public override string Name => "Prismatic Band Stage";
    public override string Description => "Animatronic Arcades are twice as effective";
    public override double Cost => double.Parse("10,000,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/band_stage_rainbow.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("animatronic_arcade") >= 300;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("animatronic_arcade", 2);
    }

}

