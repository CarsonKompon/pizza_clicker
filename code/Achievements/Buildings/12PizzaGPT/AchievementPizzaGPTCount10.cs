using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount10 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_10";
	public override string Name => "Self-taught, self-sliced";
	public override string Description => "Purchase 450 PizzaGPTs";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 450;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) / 450d;
	}
}
