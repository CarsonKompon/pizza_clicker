using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingGoldenSwitch1 : Blessing
{
	public override string Ident => "golden_switch_1";
	public override string Name => "Golden Switch";
	public override string Description => "Unlocks the golden switch, which passively boosts your pizzas/sec by 50% but disables golden pizzes.";
	public override double Cost => 999;
	public override string Icon => "/ui/icons/gold_switch_off.png";
	public override string[] Requires => new[] { "gold_pizzas_2" };
}
