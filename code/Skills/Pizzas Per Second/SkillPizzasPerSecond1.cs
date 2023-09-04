using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillPizzasPerSecond1 : Skill
{
    public override string Ident => "pizzas_per_second_multiplier_01";
    public override string Name => "Heavenly pizzas";
    public override string Description => "Cookie production multiplier +10% permanently";
    public override double Cost => 99_999;

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

