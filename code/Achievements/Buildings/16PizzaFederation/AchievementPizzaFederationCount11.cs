using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaFederationCount11 : Achievement
{
	public override string Ident => "building_16_pizza_federation_count_11";
	public override string Name => "The pizza accord";
	public override string Description => "Purchase 500 Pizza Federations";
	public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 500;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) / 500d;
	}
}
