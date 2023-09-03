using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class DeliveryDriver : Building
{
    public override string Ident => "delivery_driver";
    public override string Name => "Delivery Driver";
    public override BigNumber Cost => new(12000);
    public override BigNumber PizzasPerSecond => new(47);
}

