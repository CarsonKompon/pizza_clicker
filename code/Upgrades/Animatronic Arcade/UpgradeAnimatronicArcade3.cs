using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeAnimatronicArcade3: Upgrade
{
    public override string Ident => "upgrade_animatronic_arcade_3";
    public override string Name => "Gold Animatronic Arcade";
    public override string Description => "Animatronic Arcades are twice as effective";
    public override double Cost => 10_000_000_000;
    public override string Icon => "ui/upgrades/animatronic_arcade_gold.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.GetBuildingCount("animatronic_arcade") >= 25;
    }

    public override void OnPurchase(Player player)
    {
        player.AddMultiplier("animatronic_arcade", 2);
    }

}

