using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class BlessingGoldPizzas1 : Blessing
{

    public override string Ident => "gold_pizzas_1";
    public override string Name => "Heavenly Luck";
    public override string Description => "Golden pizzas appear 5% more often";
    public override double Cost => 77;
    public override string Icon => "/ui/pizzas/gold_pizza.png";
    public override string[] Requires => new string[] { "ascension" };

    public override void OnActivate(Player player)
    {
        player.GoldMinTime *= 0.95f;
        player.GoldMaxTime *= 0.95f;
    }

}

