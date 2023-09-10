using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementUniversityCount7 : Achievement
{
    public override string Ident => "building_11_university_count_07";
    public override string Name => "The upper crust";
    public override string Description => "Purchase 300 Pizza Universities";
    public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_university") >= 300;
	}

}

