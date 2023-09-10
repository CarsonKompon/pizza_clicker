using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class UpgradeHeavenlyPercent2 : Upgrade
{
    public override string Ident => "upgrade_heavenly_percent_2";
    public override string Name => "Heavenly crust starter";
    public override string Description => "Unlocks 25% of the potential of your ascension level.";
    public override double Cost => 1_111;
    public override string Icon => "ui/icons/trophy.png";

    public override bool CheckUnlockCondition(Player player)
    {
        return player.HasUpgrade("upgrade_heavenly_percent_1");
    }

    public override void OnPurchase(Player player)
    {
        if(player.HeavenlyPercent < 0.25d)
        {
            player.HeavenlyPercent = 0.25d;
        }
    }

}

