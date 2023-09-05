using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount8 : Achievement
{
    public override string Ident => "building_7_animatronic_arcade_count_08";
    public override string Name => "Robot rave";
    public override string Description => "Purchase 350 Animatronic Arcades";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("animatronic_arcade") >= 350;
	}

}

