using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount1 : Achievement
{
    public override string Ident => "building_7_animatronic_arcade_count_01";
    public override string Name => "It's show time!";
    public override string Description => "Purchase 1 Animatronic Arcade";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingCount("animatronic_arcade") >= 1;
	}

}

