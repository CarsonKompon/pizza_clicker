using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementUniversityCount3 : Achievement
{
    public override string Ident => "building_11_university_count_03";
    public override string Name => "Masters in marinara";
    public override string Description => "Purchase 100 Pizza Universities";
    public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_university") >= 100;
	}

}

