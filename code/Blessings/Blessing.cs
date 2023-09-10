using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class Blessing
{
    public virtual string Ident => "none";
    public virtual string Name => "None";
    public virtual string Description => "";
    public virtual double Cost => 0;
    public virtual string Icon => "ui/pizzas/cheese_pizza.png";
    public virtual string[] Requires => new string[]{ "" };

    public virtual void OnActivate(Player player)
    {

    }

    public virtual void OnAfterAscension(Player player)
    {

    }

    public static Blessing GetBlessing(string ident)
    {
        foreach(var blessing in GameMenu.AllBlessings)
        {
            if(blessing.Ident == ident)
            {
                return blessing;
            }
        }
        return null;
    }


}

