using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class PizzeriaChain : Building
{
    public override string Ident => "pizza_chain";
    public override string Name => "Pizza Chain";
    public override double Cost => 130_000;
    public override double PizzasPerSecond => 260;
}

