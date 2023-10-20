using Sandbox;
using System;
using System.Linq;

namespace PizzaClicker.Blessings;

[Library]
public class Blessing
{
	public virtual string Ident => "none";
	public virtual string Name => "None";
	public virtual string Description => "";
	public virtual double Cost => 0;
	public virtual string Icon => "ui/pizzas/cheese_pizza.png";
	public virtual string[] Requires => Array.Empty<string>();

	public virtual void OnActivate( Player player )
	{

	}

	public virtual void OnAfterAscension( Player player )
	{

	}

	public static Blessing GetBlessing( string ident )
	{
		return GameMenu.AllBlessings.FirstOrDefault( b => b.Ident == ident, null );
	}
}
