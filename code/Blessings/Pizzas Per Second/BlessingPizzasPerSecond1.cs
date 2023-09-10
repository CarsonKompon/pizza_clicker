using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingPizzasPerSecond1 : Blessing
{
    public override string Ident => "pizzas_per_second_01";
    public override string Name => "Heavenly pizzas";
    public override string Description => "Pizza production multiplier +10% permanently";
    public override double Cost => 99_999;
    public override string[] Requires => new string[] { "ascension" };
}

