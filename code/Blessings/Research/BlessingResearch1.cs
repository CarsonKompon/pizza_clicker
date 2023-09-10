using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingResearch1 : Blessing
{
    public override string Ident => "research_1";
    public override string Name => "Long-term research";
    public override string Description => "Subsequent research will be 10 times as fast.";
    public override double Cost => 5_000;
    public override string[] Requires => new string[] { "ascension" };
    public override string Icon => "ui/icons/beaker.png";


}

