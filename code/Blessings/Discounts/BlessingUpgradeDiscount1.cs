using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingUpgradeDiscount1 : Blessing
{
	public override string Ident => "upgrade_discount_01";
	public override string Name => "Divine sales";
	public override string Description => "Upgrades are 1% cheaper";
	public override double Cost => 100_000;
	public override string[] Requires => new[] { "starting_crew" };
	public override string Icon => "ui/icons/tag.png";
}
