using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class MozzarellaMine : Building
{
    public override string Ident => "mozzarella_mine";
    public override string Name => "Mozzarella Mine";
    public override double Cost => 5_100_000_000;
    public override double PizzasPerSecond => 260_000;
}

