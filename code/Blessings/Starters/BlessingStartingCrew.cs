using Sandbox;

namespace PizzaClicker.Blessings;

[Library]
public class BlessingStartingCrew : Blessing
{
	public override string Ident => "starting_crew";
	public override string Name => "Starting Crew";
	public override string Description => "You start with 5 Cheese Graters and 1 Oven";
	public override double Cost => 5_000;
	public override string[] Requires => new[] { "starting_rolling_pins" };
	public override string Icon => "ui/icons/chef.png";

	public override void OnAfterAscension( Player player )
	{
		player.GiveBuilding( "cheese_grater", 5 );
		player.GiveBuilding( "oven", 1 );
	}
}
