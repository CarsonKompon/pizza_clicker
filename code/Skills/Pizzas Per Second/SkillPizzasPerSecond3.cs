using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillPizzasPerSecond3 : Skill
{
    public override string Ident => "pizzas_per_second_multiplier_03";
    public override string Name => "All-knowing pizzas";
    public override string Description => "Cookie production multiplier +5% permanently";
    public override double Cost => 1_000_000_000;
    public override string[] Requires => new string[] { "pizzas_per_second_multiplier_03" };


    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

