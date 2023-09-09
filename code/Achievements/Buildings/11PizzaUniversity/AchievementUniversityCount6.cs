using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementUniversityCount6 : Achievement
{
    public override string Ident => "building_11_university_count_06";
    public override string Name => "Pizza Phi Beta";
    public override string Description => "Purchase 250 Pizza Universities";
    public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_university") >= 250;
	}

}

