using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class InterdimentionalPizzeria : Building
{
	public override string Ident => "interdimensional_pizzeria";
	public override string Name => "Interdimensional Pizzeria";
	public override double Cost => 170_000_000_000_000;
	public override double PizzasPerSecond => 430_000_000;
}
