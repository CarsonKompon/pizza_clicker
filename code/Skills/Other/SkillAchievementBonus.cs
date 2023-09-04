using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillAchievementBonus : Skill
{
    public override string Ident => "achievement_bonus";
    public override string Name => "Pays to be a winner";
    public override string Description => "Earn an additional +1% PpS for each achievement you have unlocked";
    public override double Cost => 100;

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

