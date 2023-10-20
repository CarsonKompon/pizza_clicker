using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingPizzasPerSecond2 : Blessing
{
	public override string Ident => "pizzas_per_second_02";
	public override string Name => "Crystal pizzas";
	public override string Description => "Pizza production multiplier +10% permanently";
	public override double Cost => 6_666_666;
	public override string[] Requires => new[] { "pizzas_per_second_01" };
}
