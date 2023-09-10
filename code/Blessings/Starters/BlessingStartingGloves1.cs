using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingStartingGloves1 : Blessing
{
    public override string Ident => "starting_gloves_1";
    public override string Name => "Small boost";
    public override string Description => "Clicks are 10% more powerful";
    public override double Cost => 55_555;
    public override string[] Requires => new string[] { "upgrade_discount_01", "building_discount_01" };
    public override string Icon => "ui/icons/hand_pinching.png";

}

