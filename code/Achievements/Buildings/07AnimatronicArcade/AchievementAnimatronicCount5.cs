using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAnimatronicCount5 : Achievement
{
	public override string Ident => "building_07_animatronic_arcade_count_05";
	public override string Name => "Mechanical rhapsody";
	public override string Description => "Purchase 200 Animatronic Arcades";
	public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "animatronic_arcade" ) >= 200;
	}
}
