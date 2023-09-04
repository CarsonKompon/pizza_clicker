using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Upgrade
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual string Description => "";
    public virtual double Cost => 0;
    public virtual string Icon => "ui/pizzas/cheese_pizza.png";

    public virtual bool CheckUnlockCondition(Player player)
    {
        return false;
    }

    public virtual void OnPurchase(Player player)
    {

    }

}

