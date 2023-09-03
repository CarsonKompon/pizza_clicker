using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Building
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual BigNumber Cost => 0;
    public virtual BigNumber PizzasPerSecond => 0;
    public virtual double PizzasPerSecondFloat => 0f;

    public BigNumber GetCost(ulong amount, ulong free = 0)
    {
        return Cost * (ulong)Math.Pow(1.15, amount - free);
    }

    public double SecondsPerPizza(ulong amount = 1)
    {
        if(PizzasPerSecondFloat == 0) return (1f / amount) / double.Parse(PizzasPerSecond.ToString());
        return (1f / amount) / (double.Parse(PizzasPerSecond.ToString()) + PizzasPerSecondFloat);
    }
}

