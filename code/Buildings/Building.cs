using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Building
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual ulong Cost => 0;
    public virtual double PizzasPerSecond => 0;

    public ulong GetCost(ulong amount, ulong free = 0)
    {
        return (ulong)(Cost * Math.Pow(1.15, amount - free));
    }

    public double SecondsPerPizza()
    {
        return 1f / PizzasPerSecond;
    }
}

