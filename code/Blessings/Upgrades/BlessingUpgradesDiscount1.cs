using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingUpgradesDiscount1 : Blessing
{
	public override string Ident => "upgrades_discount_01";
	public override string Name => "Divine sales";
	public override string Description => "Upgrades are 1% cheaper";
	public override double Cost => 99_999;
}
