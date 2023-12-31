using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount9 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_09";
	public override string Name => "Turing tested, pizza approved";
	public override string Description => "Purchase 400 PizzaGPTs";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 400;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) / 400d;
	}
}
