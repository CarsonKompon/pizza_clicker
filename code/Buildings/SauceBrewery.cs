using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class SauceBrewery : Building
{
    public override string Ident => "sauce_brewery";
    public override string Name => "Sauce Brewery";
    public override BigNumber Cost => new("1400000");
    public override BigNumber PizzasPerSecond => new("1400");
}

