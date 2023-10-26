using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementBuildingsTotal1 : Achievement
{
    public override string Ident => "buildings_total_01";
    public override string Name => "Builder";
    public override string Description => "Own 100 buildings";
    public override string Icon => "ui/icons/house.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalBuildingCount >= 100;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalBuildingCount / 100d;
	}
}
