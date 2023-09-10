using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeHeavenlyPercent3 : Upgrade
{
    public override string Ident => "upgrade_heavenly_percent_3";
    public override string Name => "Heavenly crust starter";
    public override string Description => "Unlocks 50% of the potential of your ascension level.";
    public override double Cost => 111_111;
    public override string Icon => "ui/icons/trophy.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HasUpgrade("upgrade_heavenly_percent_2");
    }

    public override void OnPurchase(Player player)
    {
        if(player.HeavenlyPercent < 0.5d)
        {
            player.HeavenlyPercent = 0.5d;
        }
    }

}

