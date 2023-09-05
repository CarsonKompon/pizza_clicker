using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount3 : Achievement
{
    public override string Ident => "building_7_animatronic_arcade_count_03";
    public override string Name => "Animatronic army";
    public override string Description => "Purchase 100 Animatronic Arcades";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("animatronic_arcade") >= 100;
	}

}

