using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingStartingGloves3 : Blessing
{
    public override string Ident => "starting_gloves_3";
    public override string Name => "Italian hands";
    public override string Description => "The effects of Toasty hands are now effective up to 100%";
    public override double Cost => 55_555_555_555;
    public override string[] Requires => new string[] { "starting_gloves_2" };
    public override string Icon => "ui/icons/hand_italian.png";

}

