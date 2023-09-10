using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingStartingGloves1 : Blessing
{
    public override string Ident => "starting_gloves_1";
    public override string Name => "Leather gloves";
    public override string Description => "Clicks are 10% more powerful";
    public override double Cost => 55_555;
    public override string[] Requires => new string[] { "starting_crew" };

}
