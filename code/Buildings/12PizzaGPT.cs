using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class PizzaGPT : Building
{
	public override string Ident => "pizza_gpt";
	public override string Name => "PizzaGPT";
	public override double Cost => 14_000_000_000_000;
	public override double PizzasPerSecond => 64_000_000;
}
