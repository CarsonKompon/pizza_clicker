using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class SauceBrewery : Building
{
	public override string Ident => "sauce_brewery";
	public override string Name => "Sauce Brewery";
	public override double Cost => 1_400_000;
	public override double PizzasPerSecond => 1_400;
}
