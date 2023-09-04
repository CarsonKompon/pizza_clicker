using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillStartingCrew : Skill
{
    public override string Ident => "starting_crew";
    public override string Name => "Starting Crew";
    public override string Description => "You start with 5 Cheese Graters and 1 Oven";
    public override double Cost => 5_000;
    public override string[] Requires => new string[] { "starting_rolling_pins" };

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

