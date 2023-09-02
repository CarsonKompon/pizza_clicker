using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class RollingPin : Building
{
    public override string Ident => "rolling_pin";
    public override string Name => "Rolling Pin";
    public override ulong Cost => 15;
    public override double PizzasPerSecond => 0.1f;
}

