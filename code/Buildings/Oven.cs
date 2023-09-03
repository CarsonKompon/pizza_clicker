using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Oven : Building
{
    public override string Ident => "oven";
    public override string Name => "Oven";
    public override BigNumber Cost => new(1100);
    public override BigNumber PizzasPerSecond => new(8);
}

