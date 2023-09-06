using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount4 : Achievement
{
    public override string Ident => "building_07_animatronic_arcade_count_04";
    public override string Name => "Arcade ensamble";
    public override string Description => "Purchase 150 Animatronic Arcades";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("animatronic_arcade") >= 150;
	}

}

