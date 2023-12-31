using Sandbox;

namespace PizzaClicker.Buildings;

[Library]
public class DeliveryDriver : Building
{
	public override string Ident => "delivery_driver";
	public override string Name => "Delivery Driver";
	public override double Cost => 12_000;
	public override double PizzasPerSecond => 47;
}
