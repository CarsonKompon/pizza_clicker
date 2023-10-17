using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingGoldenSwitch2 : Blessing
{
	public override string Ident => "golden_switch_2";
	public override string Name => "Residual luck";
	public override string Description => "While the golden switch is on, you gain an additional +10% pizzas/sec per golden pizza upgrade owned.";
	public override double Cost => 99_999;
	public override string Icon => "/ui/icons/gold_switch_on.png";
	public override string[] Requires => new[] { "golden_switch_1" };
}
