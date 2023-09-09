using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementUniversityCount11 : Achievement
{
    public override string Ident => "building_11_university_count_11";
    public override string Name => "Summa cum pizza";
    public override string Description => "Purchase 500 Pizza Universities";
    public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_university") >= 500;
	}

}

