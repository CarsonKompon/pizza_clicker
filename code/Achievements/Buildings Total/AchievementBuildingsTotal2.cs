using Sandbox;

namespace PizzaClicker.Achievements;

[Library]
public class AchievementBuildingsTotal2 : Achievement
{
    public override string Ident => "buildings_total_02";
    public override string Name => "Architect";
    public override string Description => "Own 500 buildings";
    public override string Icon => "ui/icons/house.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.TotalBuildingCount >= 500;
	}

	protected override double GetAchievementProgression( Player player )
	{
		return player.TotalBuildingCount / 500d;
	}
}
