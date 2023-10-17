using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementPizzaGPTCount5 : Achievement
{
	public override string Ident => "building_12_pizza_gpt_count_05";
	public override string Name => "Machine yearning";
	public override string Description => "Purchase 200 PizzaGPTs";
	public override string Icon => "/ui/buildings/pizza_gpt.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "pizza_gpt" ) >= 200;
	}
}
