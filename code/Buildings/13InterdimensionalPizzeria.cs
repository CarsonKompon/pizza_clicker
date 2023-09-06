using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class InterdimentionalPizzeria : Building
{
    public override string Ident => "interdimensional_pizzeria";
    public override string Name => "Interdimensional Pizzeria";
    public override double Cost => 170_000_000_000_000;
    public override double PizzasPerSecond => 430_000_000;
}

