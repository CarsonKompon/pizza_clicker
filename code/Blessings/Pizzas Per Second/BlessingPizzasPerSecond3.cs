using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingPizzasPerSecond3 : Blessing
{
    public override string Ident => "pizzas_per_second_03";
    public override string Name => "All-knowing pizzas";
    public override string Description => "Pizza production multiplier +5% permanently";
    public override double Cost => 1_000_000_000;
    public override string[] Requires => new string[] { "pizzas_per_second_02" };


}

