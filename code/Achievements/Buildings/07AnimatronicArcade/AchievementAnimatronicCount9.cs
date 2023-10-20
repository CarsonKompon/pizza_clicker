using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAnimatronicCount9 : Achievement
{
	public override string Ident => "building_07_animatronic_arcade_count_09";
	public override string Name => "Arcade master";
	public override string Description => "Purchase 400 Animatronic Arcades";
	public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "animatronic_arcade" ) >= 400;
	}
}
