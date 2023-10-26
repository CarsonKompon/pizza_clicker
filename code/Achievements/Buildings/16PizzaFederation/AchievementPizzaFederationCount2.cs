using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaFederationCount2 : Achievement
{
	public override string Ident => "building_16_pizza_federation_count_02";
	public override string Name => "Federal cheese-erve";
	public override string Description => "Purchase 50 Pizza Federations";
	public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) / 50d;
	}
}
