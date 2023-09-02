using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Oven : Building
{
    public override string Ident => "oven";
    public override string Name => "Oven";
    public override ulong Cost => 100;
    public override double PizzasPerSecond => 1f;
}

