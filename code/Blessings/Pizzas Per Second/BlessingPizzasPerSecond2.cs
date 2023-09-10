using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingPizzasPerSecond2 : Blessing
{
    public override string Ident => "pizzas_per_second_02";
    public override string Name => "Crystal pizzas";
    public override string Description => "Pizza production multiplier +10% permanently";
    public override double Cost => 6_666_666;
    public override string[] Requires => new string[] { "pizzas_per_second_01" };


}

