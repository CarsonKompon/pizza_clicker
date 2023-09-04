using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillPizzasPerSecond2 : Skill
{
    public override string Ident => "pizzas_per_second_multiplier_02";
    public override string Name => "Crystal pizzas";
    public override string Description => "Cookie production multiplier +10% permanently";
    public override double Cost => 6_666_666;
    public override string[] Requires => new string[] { "pizzas_per_second_multiplier_01" };

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

