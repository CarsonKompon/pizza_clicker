using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class RollingPin : Building
{
	public override string Ident => "rolling_pin";
	public override string Name => "Rolling Pin";
	public override double Cost => 15;
	public override double PizzasPerSecond => 0.1d;
}
