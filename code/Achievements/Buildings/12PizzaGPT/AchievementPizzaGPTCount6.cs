using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount6 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_06";
	public override string Name => "Deep dough learning";
	public override string Description => "Purchase 250 PizzaGPTs";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 250;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) / 250d;
	}
}
