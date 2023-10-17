using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingAscension : Blessing
{
	public override string Ident => "ascension";
	public override string Name => "Ascension";
	public override string Description => "Begins your journey to ascension.\n\nEach time you ascend, the pizzas you made in your past life are turned into Heavenly Crust.\n\nHeavenly Crust can be spent on a variety of future blessings.\n\nYour ascension level also gives you a permanenet +1% pizzas/sec per level.";
	public override double Cost => 1;
	public override string Icon => "/ui/icons/trophy.png";
}
