using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillUpgradesDiscount1 : Skill
{
    public override string Ident => "upgrades_discount_01";
    public override string Name => "Divine sales";
    public override string Description => "Upgrades are 1% cheaper";
    public override double Cost => 99_999;

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

