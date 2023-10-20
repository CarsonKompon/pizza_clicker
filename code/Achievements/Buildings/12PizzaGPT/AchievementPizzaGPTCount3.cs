using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount3 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_03";
	public override string Name => "Pie-Q";
	public override string Description => "Purchase 100 PizzaGPTs";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 100;
	}
}
