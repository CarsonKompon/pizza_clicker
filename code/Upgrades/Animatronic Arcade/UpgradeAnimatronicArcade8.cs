using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAnimatronicArcade8 : Upgrade
{
    public override string Ident => "upgrade_animatronic_arcade_8";
    public override string Name => "Gold Band Stage";
    public override string Description => "Animatronic Arcades are twice as effective";
    public override double Cost => double.Parse("10,000,000,000,000,000,000,000");
    public override string Icon => "ui/upgrades/band_stage_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("animatronic_arcade") >= 250;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("animatronic_arcade", 2);
    }

}

