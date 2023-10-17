using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class PizzaThemePark : Building
{
	public override string Ident => "pizza_theme_park";
	public override string Name => "Pizza Theme Park";
	public override double Cost => 330_000_000;
	public override double PizzasPerSecond => 44_000;
}
