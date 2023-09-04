using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SkillStartingRollingPins : Skill
{
    public override string Ident => "starting_rolling_pins";
    public override string Name => "Starter Kitchen";
    public override string Description => "You start with 10 Rolling Pins";
    public override double Cost => 50;

    public override bool CheckUnlockCondition(Player player)
    {
        return false;
    }

}

