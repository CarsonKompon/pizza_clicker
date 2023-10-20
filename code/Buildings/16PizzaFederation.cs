using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class PizzaFederation : Building
{
	public override string Ident => "pizza_federation";
	public override string Name => "Pizzeria Federation";
	public override double Cost => 310_000_000_000_000_000;
	public override double PizzasPerSecond => 150_000_000_000;
}
