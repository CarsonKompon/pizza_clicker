using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class CheeseGrater : Building
{
    public override string Ident => "cheese_grater";
    public override string Name => "Cheese Grater";
    public override double Cost => 100;
    public override double PizzasPerSecond => 1;
}

