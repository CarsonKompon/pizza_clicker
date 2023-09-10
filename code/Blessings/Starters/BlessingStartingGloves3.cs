using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingStartingGloves3 : Blessing
{
    public override string Ident => "starting_gloves_3";
    public override string Name => "Cosmic gauntlet";
    public override string Description => "Golden gauntlet are now effective up to 100%";
    public override double Cost => 55_555_555_555;
    public override string[] Requires => new string[] { "starting_gloves_2" };


}

