using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillClickingDiscount1 : Skill
{
    public override string Ident => "pizza_clicking_discount_01";
    public override string Name => "Divine pizzeria";
    public override string Description => "Pizza clicking upgrades are 5 times cheaper";
    public override double Cost => 99_999;

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

