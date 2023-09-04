using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AnimatronicArcade : Building
{
    public override string Ident => "animatronic_arcade";
    public override string Name => "Animatronic Arcade";
    public override double Cost => 20000000;
    public override double PizzasPerSecond => 7800;
}

