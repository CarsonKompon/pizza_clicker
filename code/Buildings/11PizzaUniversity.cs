using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class PizzaUniversity : Building
{
    public override string Ident => "pizza_university";
    public override string Name => "Pizza University";
    public override double Cost => 1_000_000_000_000;
    public override double PizzasPerSecond => 10_000_000;
}

