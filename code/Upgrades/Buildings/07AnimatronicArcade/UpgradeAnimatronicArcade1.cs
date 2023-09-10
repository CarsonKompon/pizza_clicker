using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAnimatronicArcade1 : Upgrade
{
    public override string Ident => "upgrade_animatronic_arcade_1";
    public override string Name => "Bronze Animatronic Arcade";
    public override string Description => "Animatronic Arcades are twice as effective";
    public override double Cost => 200_000_000;
    public override string Icon => "ui/upgrades/animatronic_arcade_bronze.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingResearch("animatronic_arcade") >= 1;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("animatronic_arcade", 2);
    }

}

