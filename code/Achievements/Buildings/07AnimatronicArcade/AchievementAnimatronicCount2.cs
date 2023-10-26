using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementAnimatronicCount2 : Achievement
{
	public override string Ident => "building_07_animatronic_arcade_count_02";
	public override string Name => "Fifty Nights at Frederick's";
	public override string Description => "Purchase 50 Animatronic Arcades";
	public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
		return player.GetBuildingCount( "animatronic_arcade" ) >= 50;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.GetBuildingCount( "animatronic_arcade" ) / 50d;
	}
}
