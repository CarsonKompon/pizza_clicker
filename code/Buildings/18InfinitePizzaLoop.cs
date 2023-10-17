using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class InfinitePizzaLoop : Building
{
	public override string Ident => "infinite_pizza_loop";
	public override string Name => "Infinite Pizza Loop";
	public override double Cost => float.Parse( "12,000,000,000,000,000,000,000" );
	public override double PizzasPerSecond => 8_300_000_000_000;
}
