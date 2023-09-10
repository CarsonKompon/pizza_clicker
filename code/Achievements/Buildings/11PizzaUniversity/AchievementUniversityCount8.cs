using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementUniversityCount8 : Achievement
{
    public override string Ident => "building_11_university_count_08";
    public override string Name => "Tassel hassle";
    public override string Description => "Purchase 350 Pizza Universities";
    public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_university") >= 350;
	}

}

