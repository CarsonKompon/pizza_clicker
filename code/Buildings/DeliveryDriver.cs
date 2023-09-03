using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class DeliveryDriver : Building
{
    public override string Ident => "delivery_driver";
    public override string Name => "Delivery Driver";
    public override BigNumber Cost => new(1100);
    public override BigFloat PizzasPerSecond => new(8f);
}

