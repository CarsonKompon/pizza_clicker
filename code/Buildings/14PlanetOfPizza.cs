using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class PlanetOfPizza : Building
{
    public override string Ident => "planet_of_pizza";
    public override string Name => "Planet of Pizza";
    public override double Cost => 2_100_000_000_000_000;
    public override double PizzasPerSecond => 2_900_000_000;
}

