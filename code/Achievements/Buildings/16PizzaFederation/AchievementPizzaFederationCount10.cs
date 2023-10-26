using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaFederationCount10 : Achievement
{
	public override string Ident => "building_16_pizza_federation_count_10";
	public override string Name => "Di-pie-macy";
	public override string Description => "Purchase 450 Pizza Federations";
	public override string Icon => "/ui/buildings/pizza_federation.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) >= 450;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_federation" ) / 450d;
	}
}
