using Sandbox;
using Sandbox.UI;
using System;

namespace PizzaClicker;

[Library]
public class AchievementAnimatronicCount11 : Achievement
{
    public override string Ident => "building_07_animatronic_arcade_count_11";
    public override string Name => "It's all fun and games";
    public override string Description => "Purchase 500 Animatronic Arcades";
    public override string Icon => "/ui/buildings/animatronic_arcade.png";

	public override bool CheckUnlockCondition( Player player )
	{
        return player.GetBuildingResearch("animatronic_arcade") >= 500;
	}

}

