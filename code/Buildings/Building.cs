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

    public BigNumber GetCost(ulong amount, ulong free = 0)
    {
        return Cost * (ulong)Math.Pow(1.15, amount - free);
    }

    public BigNumber SecondsPerPizza()
    {
        return new BigNumber(1f) / PizzasPerSecond;
    }
}

