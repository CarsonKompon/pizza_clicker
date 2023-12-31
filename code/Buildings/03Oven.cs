using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class Oven : Building
{
	public override string Ident => "oven";
	public override string Name => "Oven";
	public override double Cost => 1_100;
	public override double PizzasPerSecond => 8;
}
