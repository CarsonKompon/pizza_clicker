using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementUniversityCount4 : Achievement
{
    public override string Ident => "building_11_university_count_04";
    public override string Name => "Dough-ctorate";
    public override string Description => "Purchase 150 Pizza Universities";
    public override string Icon => "/ui/buildings/pizza_university.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("pizza_university") >= 150;
	}

}

