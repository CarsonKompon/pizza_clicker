using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class DeliveryDriver : Building
{
    public override string Ident => "delivery_driver";
    public override string Name => "Delivery Driver";
    public override ulong Cost => 1100;
    public override double PizzasPerSecond => 8f;
}

