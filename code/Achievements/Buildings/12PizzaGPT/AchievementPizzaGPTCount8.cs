using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount8 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_08";
	public override string Name => "Data slice";
	public override string Description => "Purchase 350 PizzaGPTs";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 350;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) / 350d;
	}
}
