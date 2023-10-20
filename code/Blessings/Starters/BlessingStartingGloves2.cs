using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingStartingGloves2 : Blessing
{
	public override string Ident => "starting_gloves_2";
	public override string Name => "Toasty hands";
	public override string Description => "Clicks are 0.5% more powerful for each Oven you own (up to 50%)";
	public override double Cost => 555_555_555;
	public override string[] Requires => new[] { "starting_gloves_1" };
	public override string Icon => "ui/icons/hand_ok.png";
}
