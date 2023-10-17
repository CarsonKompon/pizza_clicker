using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingResearch1 : Blessing
{
	public override string Ident => "research_1";
	public override string Name => "Long-term research";
	public override string Description => "Subsequent research will be 10 times as fast.";
	public override double Cost => 500;
	public override string[] Requires => new[] { "ascension" };
	public override string Icon => "ui/icons/beaker.png";

	public override void OnActivate( Player player )
	{
		player.ResearchSpeed *= 10;
	}
}
