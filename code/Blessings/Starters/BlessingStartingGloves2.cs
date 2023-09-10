using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingStartingGloves2 : Blessing
{
    public override string Ident => "starting_gloves_2";
    public override string Name => "Golden gauntlet";
    public override string Description => "Clicks are 1% more powerful for each Oven you own (up to 50%)";
    public override double Cost => 555_555_555;
    public override string[] Requires => new string[] { "starting_gloves_1" };


}
