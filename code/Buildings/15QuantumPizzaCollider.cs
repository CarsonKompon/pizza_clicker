using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class QuantumPizzaCollider : Building
{
    public override string Ident => "quantum_pizza_collider";
    public override string Name => "Quantum Pizza Collider";
    public override double Cost => 26_000_000_000_000_000;
    public override double PizzasPerSecond => 21_000_000_000;
}

