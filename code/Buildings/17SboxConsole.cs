using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SboxConsole : Building
{
    public override string Ident => "sbox_console";
    public override string Name => "S&box Console";
    public override double Cost => float.Parse("71,000,000,000,000,000,000");
    public override double PizzasPerSecond => 1_100_000_000_000;
}

