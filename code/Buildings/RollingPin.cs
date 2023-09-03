using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class RollingPin : Building
{
    public override string Ident => "rolling_pin";
    public override string Name => "Rolling Pin";
    public override BigNumber Cost => new(15);
    public override BigNumber PizzasPerSecond => new(0.1f);
}

