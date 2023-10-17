using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingGoldPizzas2 : Blessing
{
	public override string Ident => "gold_pizzas_2";
	public override string Name => "Lasting fortune";
	public override string Description => "Golden pizza effects last 10% longer.";
	public override double Cost => 777;
	public override string Icon => "/ui/pizzas/gold_pizza.png";
	public override string[] Requires => new[] { "gold_pizzas_1" };

	public override void OnActivate( Player player )
	{
		player.GoldMinTime *= 0.95f;
		player.GoldMaxTime *= 0.95f;
	}
}
