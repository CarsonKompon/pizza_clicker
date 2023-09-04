using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AnimatronicArcade : Building
{
    public override string Ident => "animatronic_arcade";
    public override string Name => "Animatronic Arcade";
    public override BigNumber Cost => new("20000000");
    public override BigNumber PizzasPerSecond => new("7800");
}

