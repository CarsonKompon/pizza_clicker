using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class PizzeriaChain : Building
{
    public override string Ident => "pizza_chain";
    public override string Name => "Pizza Chain";
    public override BigNumber Cost => new("130000");
    public override BigNumber PizzasPerSecond => new("260");
}

