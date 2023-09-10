using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount10 : Achievement
{
    public override string Ident => "building_07_animatronic_arcade_count_10";
    public override string Name => "Arcade of legends";
    public override string Description => "Purchase 450 Animatronic Arcades";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("animatronic_arcade") >= 450;
	}

}

