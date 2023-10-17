using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount11 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_11";
	public override string Name => "Self-taught, self-sliced";
	public override string Description => "Robots making robots making pizza";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 500;
	}
}
