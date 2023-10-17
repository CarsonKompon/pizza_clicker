using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class SodaFountainFactory : Building
{
	public override string Ident => "soda_fountain_factory";
	public override string Name => "Soda Fountain Factory";
	public override double Cost => 75_000_000_000;
	public override double PizzasPerSecond => 1_600_000;
}
