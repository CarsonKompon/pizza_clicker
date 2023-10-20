using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class AnimatronicArcade : Building
{
	public override string Ident => "animatronic_arcade";
	public override string Name => "Animatronic Arcade";
	public override double Cost => 20_000_000;
	public override double PizzasPerSecond => 7_800;
}
